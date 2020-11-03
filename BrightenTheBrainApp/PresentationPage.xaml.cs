using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrightenTheBrainApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PresentationPage : ContentPage
    {
        public PresentationPage()
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

        private void GoogCalButton_Pressed(object sender, EventArgs e)
        {
            GoogCalButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void GoogCalButton_Released(object sender, EventArgs e)
        {
            GoogCalButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://calendar.google.com/calendar/b/1/r/month/2019/9/1?cid=bm1xc3JlYnVwMzUxbzJmMjczbmo3NTNqMzBAZ3JvdXAuY2FsZW5kYXIuZ29vZ2xlLmNvbQ"));
        }

        private void OnPresButton_Pressed(object sender, EventArgs e)
        {
            OnPresButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void OnPresButton_Released(object sender, EventArgs e)
        {
            OnPresButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/1qzie652WtRrNDVS1tPkx6_PizeYjDEbc/view?usp=sharing")); 
        }

        private void ResultsButton_Pressed(object sender, EventArgs e)
        {
            ResultsButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void ResultsButton_Released(object sender, EventArgs e)
        {
            ResultsButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/12-pU2fpgAK1n8T7-hduoLS2T-j1SL5uo/view?usp=sharing")); 
        }

        private void TemplateEmailButton_Pressed(object sender, EventArgs e)
        {
            TemplateEmailButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void TemplateEmailButton_Released(object sender, EventArgs e)
        {
            TemplateEmailButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/1WhEyfz6t4HZeHKkOc1f1e1qe-dYfguHQ/view?usp=sharing")); 
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