using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrightenTheBrainApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ColorsPage : ContentPage
    {
        public ColorsPage()
        {
            InitializeComponent();
        }

        private async void BrightBeingLogo_Clicked(object sender, EventArgs e)
        {
            int numModals = Application.Current.MainPage.Navigation.ModalStack.Count;
            for (int currModal = 1; currModal < numModals; currModal++)
            {
                await Application.Current.MainPage.Navigation.PopModalAsync(); //gets rid of all modal asyncs within the stack. over stacking leads to app crash.
            }
        }

        private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            //Will search database for entry
            // DisplayAlert("Working", "it's working:" + SearchEntry.Text, "ok");
        }

        private void RedButton_Pressed(object sender, EventArgs e)
        {
            RedButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void RedButton_Released(object sender, EventArgs e)
        {
            RedButton.BackgroundColor = Color.WhiteSmoke;
            RedPage red = new RedPage(); //Creates an instance of the RedPage form called "red"
            Navigation.PushModalAsync(red); //Opens new RedPage using the name "red" 
        }

        private void BlueButton_Pressed(object sender, EventArgs e)
        {
            BlueButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void BlueButton_Released(object sender, EventArgs e)
        {
            BlueButton.BackgroundColor = Color.WhiteSmoke;
            BluePage blue = new BluePage(); //Creates an instance of the BluePage form called "blue"
            Navigation.PushModalAsync(blue); //Opens new BluePage using the name "blue" 
        }

        private void GreenButton_Pressed(object sender, EventArgs e)
        {
            GreenButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void GreenButton_Released(object sender, EventArgs e)
        {
            GreenButton.BackgroundColor = Color.WhiteSmoke;
            GreenPage green = new GreenPage(); //Creates an instance of the GreenPage form called "green"
            Navigation.PushModalAsync(green); //Opens new GreenPage using the name "green" 
        }

        private void YellowButton_Pressed(object sender, EventArgs e)
        {
            YellowButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void YellowButton_Released(object sender, EventArgs e)
        {
            YellowButton.BackgroundColor = Color.WhiteSmoke;
            YellowPage yellow = new YellowPage(); //Creates an instance of the YellowPage form called "yellow"
            Navigation.PushModalAsync(yellow); //Opens new YellowPage using the name "yellow" 
        }

        void OnButtonPressedBack(object sender, EventArgs args)
        {
            BackButton.BackgroundColor = Color.Black;
        }

        void OnButtonReleasedBack(object sender, EventArgs args)
        {
            BackButton.BackgroundColor = Color.FromHex("#2b2b2b");
            Navigation.PopModalAsync();
        }
    }
}