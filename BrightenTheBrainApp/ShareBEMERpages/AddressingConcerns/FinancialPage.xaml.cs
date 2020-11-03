using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrightenTheBrainApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FinancialPage : ContentPage
    {
        public FinancialPage()
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

        private void BuyBackButton_Pressed(object sender, EventArgs e)
        {
            BuyBackButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void BuyBackButton_Released(object sender, EventArgs e)
        {
            BuyBackButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/1kNe7lrGkMWHz2gGpTo6b8wbmWty3mt5I/view?usp=sharing")); 
        }

        private void ObjectionButton_Pressed(object sender, EventArgs e)
        {
            ObjectionButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void ObjectionButton_Released(object sender, EventArgs e)
        {
            ObjectionButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/1SLj3t0ZzcPJKYdzOLqcVXmr6rNCsgTbh/view?usp=sharing")); 
        }

        private void PayButton_Pressed(object sender, EventArgs e)
        {
            PayButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void PayButton_Released(object sender, EventArgs e)
        {
            PayButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/1A8eKzh6_7b_MmFc6LAulUkqFmUZw4DYp/view?usp=sharing")); 
        }

        private void CCAppButton_Pressed(object sender, EventArgs e)
        {
            CCAppButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void CCAppButton_Released(object sender, EventArgs e)
        {
            CCAppButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/0BxHmt1fEc6kQM3F1VXBqS2VydVk/view?usp=sharing")); 
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