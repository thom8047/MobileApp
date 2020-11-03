using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrightenTheBrainApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DIWorkPage : ContentPage
    {
        public DIWorkPage()
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

        private void CureButton_Pressed(object sender, EventArgs e)
        {
            CureButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void CureButton_Released(object sender, EventArgs e)
        {
            CureButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/16z2PloSn0Ez0UPDZAQql-IiDOjHBoWiQ/view?usp=sharing")); 
        }

        private void ConditionButton_Pressed(object sender, EventArgs e)
        {
            ConButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void ConditionButton_Released(object sender, EventArgs e)
        {
            ConButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/15i7GgYLtcnofoTolKn31VAdnzZ_Rngnp/view?usp=sharing")); 
        }

        private void ExerciseButton_Pressed(object sender, EventArgs e)
        {
            ExerciseButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void ExerciseButton_Released(object sender, EventArgs e)
        {
            ExerciseButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/1f6LY72WQXPbCiYY0LSTIlliE_8jNHCf7/view?usp=sharing")); 
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