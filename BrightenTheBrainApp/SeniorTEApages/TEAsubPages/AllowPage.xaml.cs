using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrightenTheBrainApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AllowPage : ContentPage
    {
        public AllowPage()
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

        private void PaceButton_Pressed(object sender, EventArgs e)
        {
            PaceButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void PaceButton_Released(object sender, EventArgs e)
        {
            PaceButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/1y5XSf0kyPxxN-wipXvDD_qBp-wUa1yUn/view?usp=sharing"));
        }

        private void StyleButton_Pressed(object sender, EventArgs e)
        {
            StyleButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void StyleButton_Released(object sender, EventArgs e)
        {
            StyleButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/1JXYpAbBIO2lpp-7YuAhHZQky1ORuUFM-/view?usp=sharing"));
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