using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Essentials;
using System.Linq;

namespace BrightenTheBrain
{
    class Display
    {
        public IEnumerable<ButtonData> GetButtonData()
        {
            var obj = new Reader();
            var button_data = obj.CSV();
            return button_data;
        }
        public StackLayout ReturnStack(List<Button> buttons)
        {
            //Specific csv that has only the button data that we want to put in stack and return that stack to put in the content.
            var stack = new StackLayout();

            foreach (var button in buttons)
            {
                stack.Children.Add(button);
            }/*
            var scroll = new ScrollView
            {
                Content = stack
            };
            */
            return stack;
        }

        public StackLayout GetButtons(string form_name, StackLayout main, ScrollView scroll, List<String> neededFormNames)
        {
            //var DisplayObject = new Display();

            var button_data = this.GetButtonData();
            var button_list = new List<Button>();

            foreach (var piece in button_data)
            {
                if (piece.FormName == form_name)
                {
                    var button = new Button
                    {
                        // Physical look of buttons
                        Text = piece.ButtonName,
                        FontSize = 32,
                        VerticalOptions = LayoutOptions.Center,
                        CornerRadius = 0,
                        BackgroundColor = Color.FromHex("#42D7D6"),
                        TextColor = Color.White,
                    };
                    button.Clicked += async (s, e) =>
                    {
                        await Browser.OpenAsync(piece.Link);
                    };
                    button_list.Add(button);
                }
            }

            var BackButton = new Button
            {
                Text = "Back",
                FontSize = 32,
                VerticalOptions = LayoutOptions.Center,
                CornerRadius = 0,
                BackgroundColor = Color.DarkGray,
            };
            BackButton.Clicked += (s, e) =>
            {
                this.GetMainPage(scroll, main, neededFormNames);
            };

            button_list.Add(BackButton);
            var GetStack = this.ReturnStack(button_list);

            return GetStack;
        }

        public StackLayout GetSubPage(string form_name, StackLayout main, ScrollView scroll, List<String> neededFormNames)
        {
            var GetStack = this.GetButtons(form_name, main, scroll, neededFormNames);

            return GetStack;
        }
        public void GetMainPage(ScrollView scroll, StackLayout main, List<String> neededFormNames)
        {
            var button_data = this.GetButtonData();
            var categories = button_data.Select(x => x.FormName).Distinct().ToList();
            var category = new List<Button>();

            foreach (var str in categories)
            {
                string check = neededFormNames
                    .Where(stringToCheck => stringToCheck.Contains(str)).FirstOrDefault();
                if (check != null)
                {
                    var category_button = new Button
                    {
                        Text = str,
                        FontSize = 32,
                        VerticalOptions = LayoutOptions.Center,
                        CornerRadius = 0,
                        BackgroundColor = Color.FromHex("#42D7D6"),
                        TextColor = Color.White,
                    };
                    category_button.Clicked += (s, e) =>
                    {
                        var sub = this.GetSubPage(category_button.Text, main, scroll, neededFormNames);
                        scroll.Content = sub;
                    };

                    category.Add(category_button);
                }
                else
                {
                    Console.WriteLine("Was not accepted: " + str);
                    continue; }//Catch the else
            }

            var GetStack = this.ReturnStack(category);
            scroll.Content = GetStack;
        }
    }
}
