using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrightenTheBrainApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppointmentPage : ContentPage
    {
        public AppointmentPage()
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

        private void LISTButton_Pressed(object sender, EventArgs e)
        {
            LISTButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void LISTButton_Released(object sender, EventArgs e)
        {
            LISTButton.BackgroundColor = Color.WhiteSmoke;
            LISTPage listenpage = new LISTPage();
            Navigation.PushModalAsync(listenpage);
        }

        private void PresButton_Pressed(object sender, EventArgs e)
        {
            PresButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void PresButton_Released(object sender, EventArgs e)
        {
            PresButton.BackgroundColor = Color.WhiteSmoke;
            PresentationPage present = new PresentationPage();
            Navigation.PushModalAsync(present);
        }

        private void PitchButton_Pressed(object sender, EventArgs e)
        {
            PitchButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void PitchButton_Released(object sender, EventArgs e)
        {
            PitchButton.BackgroundColor = Color.WhiteSmoke;
            PitchPage pitch = new PitchPage();
            Navigation.PushModalAsync(pitch);
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