using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrightenTheBrainApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Demonstration : ContentPage
    {
        public Demonstration()
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

        private void Demo1Button_Pressed(object sender, EventArgs e)
        {
            Demo1Button.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void Demo1Button_Released(object sender, EventArgs e)
        {
            Demo1Button.BackgroundColor = Color.WhiteSmoke;
            Demo1 dem1 = new Demo1(); //Creates an instance of the Demo1 form called "dem1"
            Navigation.PushModalAsync(dem1); //Opens new Demo1 using the name "dem1" 
        }

        private void Demo2Button_Pressed(object sender, EventArgs e)
        {
            Demo2Button.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void Demo2Button_Released(object sender, EventArgs e)
        {
            Demo2Button.BackgroundColor = Color.WhiteSmoke;
            Demo2 dem2 = new Demo2(); //Creates an instance of the Demo2 form called "dem2"
            Navigation.PushModalAsync(dem2); //Opens new Demo2 using the name "dem2" 
        }

        private void Demo3Button_Pressed(object sender, EventArgs e)
        {
            Demo3Button.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void Demo3Button_Released(object sender, EventArgs e)
        {
            Demo3Button.BackgroundColor = Color.WhiteSmoke;
            Demo3 dem3 = new Demo3(); //Creates an instance of the Demo3 form called "dem3"
            Navigation.PushModalAsync(dem3); //Opens new Demo3 using the name "dem3"
        }

        private void OffersButton_Pressed(object sender, EventArgs e)
        {
            OffersButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void OffersButton_Released(object sender, EventArgs e)
        {
            OffersButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/1BLUZ2wxI4B1pVV-SVajtmMLyt9NkD11k/view?usp=sharing")); 
        }

        private void SessionButton_Pressed(object sender, EventArgs e)
        {
            SessionButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void SessionButton_Released(object sender, EventArgs e)
        {
            SessionButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/1sD0m2uWubil6dDy6eUStWD9mSgehn4tH/view?usp=sharing")); 
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