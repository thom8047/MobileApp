using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrightenTheBrainApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CoffeePage : ContentPage
    {
        public CoffeePage()
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

        private void ConnectButton_Pressed(object sender, EventArgs e)
        {
            ConnectButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void ConnectButton_Released(object sender, EventArgs e)
        {
            ConnectButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/1sri2_r80msBtzEpuNg0qFUs_Yq5eJyT0/view?usp=sharing"));
        }

        private void OfferButton_Pressed(object sender, EventArgs e)
        {
            OfferButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void OfferButton_Released(object sender, EventArgs e)
        {
            OfferButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/1Qontvsuo5h9kfkv_2-Dc38EcMmU1kqU9/view?usp=sharing"));
        }

        private void FollowShortButton_Pressed(object sender, EventArgs e)
        {
            FollowShortButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void FollowShortButton_Released(object sender, EventArgs e)
        {
            FollowShortButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/1dQeLohYoaHqbxgABBESbKCO9IeTphJVm/view?usp=sharing"));
        }

        private void FollowLongButton_Pressed(object sender, EventArgs e)
        {
            FollowLongButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void FollowLongButton_Released(object sender, EventArgs e)
        {
            FollowLongButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/13CbJ1Lp7zA6C7nnTJBICqaRCklzjFAf-/view?usp=sharing"));
        }

        private void EngageButton_Pressed(object sender, EventArgs e)
        {
            EngageButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void EngageButton_Released(object sender, EventArgs e)
        {
            EngageButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/1INUsaCV_x_4p7AhSVSEVkHVLhKMR51sf/view?usp=sharing"));
        }

        private void EnjoyButton_Pressed(object sender, EventArgs e)
        {
            EnjoyButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void EnjoyButton_Released(object sender, EventArgs e)
        {
            EnjoyButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/1av-6DUq_WiihEGwt6BblijL_MAdomu64/view?usp=sharing"));
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