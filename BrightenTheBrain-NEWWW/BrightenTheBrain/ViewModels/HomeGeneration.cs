using System;
using System.Collections.Generic;
using System.Text;

using Xamarin.Forms;

namespace BrightenTheBrain.ViewModels
{
    class HomeGeneration
    {
        public IEnumerable<ButtonData> getData()
        {
            var reader = new Reader();
            var data = reader.CSV();

            return data;
        }
        public ScrollView returnStack()
        {
            var data = this.getData();
            var layout = new StackLayout();
            var scroll = new ScrollView();
 
            foreach (ButtonData element in data)
            {
                var button = new Button
                {
                    Text=element.ButtonName,
                    FontSize=32,
                    VerticalOptions = LayoutOptions.Center,
                    CornerRadius = 0,
                    BackgroundColor = Color.Black,
                    TextColor = Color.White,
                };
                layout.Children.Add(button);
            }
            scroll.Content = layout;
            return scroll;
        }
    }
}
