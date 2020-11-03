using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrightenTheBrainApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CompanyPage : ContentPage
    {
        public CompanyPage()
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

        private void MLMButton_Pressed(object sender, EventArgs e)
        {
            MLMButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void MLMButton_Released(object sender, EventArgs e)
        {
            MLMButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/1OszU0NNYZM9M6G7THbGsm0IJyk2buNDO/view?usp=sharing")); 
        }

        private void CompButton_Pressed(object sender, EventArgs e)
        {
            CompButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void CompButton_Released(object sender, EventArgs e)
        {
            CompButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/1cB1MNEibNQIYlGNUH4Hm-PDRkfAsq0L9/view?usp=sharing")); 
        }

        private void AmazonButton_Pressed(object sender, EventArgs e)
        {
            AmazonButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void AmazonButton_Released(object sender, EventArgs e)
        {
            AmazonButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/13xSXJtPwunuWSRYCRYN1LS6uc-Uqov7b/view?usp=sharing")); 
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