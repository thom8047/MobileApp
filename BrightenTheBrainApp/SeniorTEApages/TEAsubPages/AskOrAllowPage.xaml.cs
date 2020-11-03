using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrightenTheBrainApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AskOrAllowPage : ContentPage
    {
        public AskOrAllowPage()
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

        private void AskButton_Pressed(object sender, EventArgs e)
        {
            AskButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void AskButton_Released(object sender, EventArgs e)
        {
            AskButton.BackgroundColor = Color.WhiteSmoke;
            AskPage ask = new AskPage(); //Creates an instance of the AskPage form called "ask"
            Navigation.PushModalAsync(ask); //Opens new AskPage using the name "ask"
        }

        private void AllowButton_Pressed(object sender, EventArgs e)
        {
            AllowButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void AllowButton_Released(object sender, EventArgs e)
        {
            AllowButton.BackgroundColor = Color.WhiteSmoke;
            AllowPage allow = new AllowPage(); //Creates an instance of the AllowPage form called "allow"
            Navigation.PushModalAsync(allow); //Opens new AllowPage using the name "allow"
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