using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrightenTheBrainApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EducateTea : ContentPage
    {
        public EducateTea()
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

        private void SeriesButton_Pressed(object sender, EventArgs e)
        {
            SeriesButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void SeriesButton_Released(object sender, EventArgs e)
        {
            SeriesButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/1kDHGW-0I6in31-bpWNF7lSh_9VUN7lF7/view")); 
        }

        private void AcademyButton_Pressed(object sender, EventArgs e)
        {
            AcademyButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void AcademyButton_Released(object sender, EventArgs e)
        {
            AcademyButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/0BxHmt1fEc6kQMWlkT2V6SDlmZ1U/view?usp=sharing")); 
        }

        private void GetStartButton_Pressed(object sender, EventArgs e)
        {
            GetStartButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void GetStartButton_Released(object sender, EventArgs e)
        {
            GetStartButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/1tac-SABmRjrLDMkwTwCi1q0suZh2efQW/view?usp=sharing")); 
        }

        private void JoinButton_Pressed(object sender, EventArgs e)
        {
            JoinButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void JoinButton_Released(object sender, EventArgs e)
        {
            JoinButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/1BLUZ2wxI4B1pVV-SVajtmMLyt9NkD11k/view?usp=sharing")); 
        }

        private void RegResButton_Pressed(object sender, EventArgs e)
        {
            RegResButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void RegResButton_Released(object sender, EventArgs e)
        {
            RegResButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/1r5eOusJUxmYIQOyAmoSLF0KgzXJis0eA/view?usp=sharing")); 
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