using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrightenTheBrain.Views
{
    public partial class SearchPage : ContentPage
    {
        public void Display()
        {
            // Figure it out.
        }
        public SearchPage()
        {
            //InitializeComponent();
            /*Label label = new Label
            {
                Text = "Brighten The Brain",
                TextColor = Color.White,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                VerticalOptions = LayoutOptions.Center,
            };*/
            Image image = new Image
            {
                Source = "BrightenBeing.PNG",
                VerticalOptions = LayoutOptions.Center,
                HeightRequest = 180,
                WidthRequest = 390,
            };

            SearchBar bar = new SearchBar();
            var stack = new StackLayout();
            var scroll = new ScrollView();
            stack.BackgroundColor = Color.FromHex("#424242");
            Content = stack;
            stack.Children.Add(image);
            stack.Children.Add(bar);
            stack.Children.Add(scroll);

            var forms = new List<String> { "L.I.S.T.", "C.O.F.F.E.E. " };


            //Get DisplayObject and get buttons

            var DisplayObject = new Display();
            DisplayObject.GetMainPage(scroll, stack, forms);
        }
    }
}