using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrightenTheBrainApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Demo2 : ContentPage
    {
        public Demo2()
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

        private void Demo1PlaceholderButton_Pressed(object sender, EventArgs e)
        {
            Demo1PlaceholderButton.BackgroundColor = Color.Black;
        }

        private void Demo1PlaceholderButton_Released(object sender, EventArgs e)
        {
            Demo1PlaceholderButton.BackgroundColor = Color.FromHex("#2b2b2b");
            Demo1 dem1 = new Demo1(); //Creates an instance of the Demo1 form called "dem1"
            Navigation.PushModalAsync(dem1); //Opens new Demo1 using the name "dem1" 
        }

        private void Demo2PlaceholderButton_Pressed(object sender, EventArgs e)
        {
            Demo2PlaceholderButton.BackgroundColor = Color.WhiteSmoke;
        }

        private void Demo2PlaceholderButton_Released(object sender, EventArgs e)
        {
            Demo2PlaceholderButton.BackgroundColor = Color.WhiteSmoke;
        }

        private void Demo3PlaceholderButton_Pressed(object sender, EventArgs e)
        {
            Demo3PlaceholderButton.BackgroundColor = Color.Black;
        }

        private void Demo3PlaceholderButton_Released(object sender, EventArgs e)
        {
            Demo3PlaceholderButton.BackgroundColor = Color.FromHex("#2b2b2b");
            Demo3 dem3 = new Demo3(); //Creates an instance of the Demo3 form called "dem3"
            Navigation.PushModalAsync(dem3); //Opens new Demo3 using the name "dem3"
        }

        private void CheckButton_Pressed(object sender, EventArgs e)
        {
            CheckButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void CheckButton_Released(object sender, EventArgs e)
        {
            CheckButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/1KIw18pe7ovvAYf4SBhAVDVZeQ1fOoriS/view?usp=sharing")); 
        }

        private void AddConcButton_Pressed(object sender, EventArgs e)
        {
            AddConcButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void AddConcButton_Released(object sender, EventArgs e)
        {
            AddConcButton.BackgroundColor = Color.WhiteSmoke;
            AddressConcernPage adconcern = new AddressConcernPage(); //Creates an instance of the AddressConcernPage form called "adconcern"
            Navigation.PushModalAsync(adconcern); //Opens new AddressConcernPage using the name "adconcern"
        }

        private void RelevantButton_Pressed(object sender, EventArgs e)
        {
            RelevantButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void RelevantButton_Released(object sender, EventArgs e)
        {
            RelevantButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/1ZUd-Gw9EfqifICRenE--1cNiZVUd7cSX/view?usp=sharing")); 
        }

        private void OtherStoriesButton_Pressed(object sender, EventArgs e)
        {
            OtherStoriesButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void OtherStoriesButton_Released(object sender, EventArgs e)
        {
            OtherStoriesButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/12-pU2fpgAK1n8T7-hduoLS2T-j1SL5uo/view?usp=sharing")); 
        }

        private void Offer3Button_Pressed(object sender, EventArgs e)
        {
            Offer3Button.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void Offer3Button_Released(object sender, EventArgs e)
        {
            Offer3Button.BackgroundColor = Color.WhiteSmoke;
            Demo3 dem3 = new Demo3(); //Creates an instance of the Demo3 form called "dem3"
            Navigation.PushModalAsync(dem3); //Opens new Demo3 using the name "dem3" 
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