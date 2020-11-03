using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrightenTheBrainApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CloseSalePage : ContentPage
    {
        public CloseSalePage()
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

        private void NewIBDButton_Pressed(object sender, EventArgs e)
        {
            NewIBDButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void NewIBDButton_Released(object sender, EventArgs e)
        {
            NewIBDButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/1UmIVyiBUxQZxHumcxJ0rAUfJGw7m2HpF/view?usp=sharing"));
        }

        private void NewCustButton_Pressed(object sender, EventArgs e)
        {
            NewCustButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void NewCustButton_Released(object sender, EventArgs e)
        {
            NewCustButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/1Qtt8wmC5WajcyTmBwK6XKnv2W9O9JQOU/view?usp=sharing"));
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