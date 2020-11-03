using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrightenTheBrainApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EducatePage : ContentPage
    {
        public EducatePage()
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

        private void DripsButton_Pressed(object sender, EventArgs e)
        {
            DripsButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void DripsButton_Released(object sender, EventArgs e)
        {
            DripsButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/1ZUd-Gw9EfqifICRenE--1cNiZVUd7cSX/view?usp=sharing"));
        }

        private void TableBooksButton_Pressed(object sender, EventArgs e)
        {
            TableBooksButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void TableBooksButton_Released(object sender, EventArgs e)
        {
            TableBooksButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/1KP1uqAVVAYfBX0x1qhBUmt4mCPaAclCa/view?usp=sharing"));
        }

        private void ResRusButton_Pressed(object sender, EventArgs e)
        {
            ResRusButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void ResRusButton_Released(object sender, EventArgs e)
        {
            ResRusButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/12-pU2fpgAK1n8T7-hduoLS2T-j1SL5uo/view?usp=sharing"));
        }

        private void OfferButton_Pressed(object sender, EventArgs e)
        {
            OfferButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void OfferButton_Released(object sender, EventArgs e)
        {
            OfferButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/1BLUZ2wxI4B1pVV-SVajtmMLyt9NkD11k/view?usp=sharing"));
        }

        private void FollowUpButton_Pressed(object sender, EventArgs e)
        {
            FollowUpButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void FollowUpButton_Released(object sender, EventArgs e)
        {
            FollowUpButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/1ihdgmRu60HZFfAnVwDc3Y3C9wVjNlG0c/view?usp=sharing"));  
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