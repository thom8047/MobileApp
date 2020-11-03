using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrightenTheBrainApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AskPage : ContentPage
    {
        public AskPage()
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

        private void MentorButton_Pressed(object sender, EventArgs e)
        {
            MentorButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void MentorButton_Released(object sender, EventArgs e)
        {
            MentorButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/1sYvWCYiwfON4T1qMS6DeLKiitx5PUTTX/view?usp=sharing")); 
        }

        private void SupportButton_Pressed(object sender, EventArgs e)
        {
            SupportButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void SupportButton_Released(object sender, EventArgs e)
        {
            SupportButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/17qGq8uCCq5ine-tJ-vDyjxA788hJvvDl/view?usp=sharing")); 
        }

        private void RecognizeButton_Pressed(object sender, EventArgs e)
        {
            RecognizeButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void RecognizeButton_Released(object sender, EventArgs e)
        {
            RecognizeButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/1h2AZfWJFK3COU116PVJcEA9Z6Mn96h1R/view?usp=sharing")); 
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