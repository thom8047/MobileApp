using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrightenTheBrainApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TeaPage : ContentPage
    {
        public TeaPage()
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

        private void TrainButton_Pressed(object sender, EventArgs e)
        {
            TrainButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void TrainButton_Released(object sender, EventArgs e)
        {
            TrainButton.BackgroundColor = Color.WhiteSmoke;
            TrainingIA train = new TrainingIA();
            Navigation.PushModalAsync(train);
        }

        private void EducateButton_Pressed(object sender, EventArgs e)
        {
            EducateButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void EducateButton_Released(object sender, EventArgs e)
        {
            EducateButton.BackgroundColor = Color.WhiteSmoke;
            EducateTea educate = new EducateTea();
            Navigation.PushModalAsync(educate);
        }

        private void AskAllowButton_Pressed(object sender, EventArgs e)
        {
            AskAllowButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void AskAllowButton_Released(object sender, EventArgs e)
        {
            AskAllowButton.BackgroundColor = Color.WhiteSmoke;
            AskOrAllowPage askallow = new AskOrAllowPage();
            Navigation.PushModalAsync(askallow);
        }

        private void HomeButton_Pressed(object sender, EventArgs e)
        {
            HomeButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void HomeButton_Released(object sender, EventArgs e)
        {
            HomeButton.BackgroundColor = Color.WhiteSmoke;
            HOMEPage HOME = new HOMEPage(); //Creates an instance of the HOMEPage form called "HOME"
            Navigation.PushModalAsync(HOME); //Opens new HOMEPage using the name "HOME"
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