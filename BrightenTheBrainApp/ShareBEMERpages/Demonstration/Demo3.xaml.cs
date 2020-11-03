using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrightenTheBrainApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Demo3 : ContentPage
    {
        public Demo3()
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
            Demo2PlaceholderButton.BackgroundColor = Color.Black;
        }

        private void Demo2PlaceholderButton_Released(object sender, EventArgs e)
        {
            Demo2PlaceholderButton.BackgroundColor = Color.FromHex("#2b2b2b");
            Demo2 dem2 = new Demo2(); //Creates an instance of the Demo2 form called "dem2"
            Navigation.PushModalAsync(dem2); //Opens new Demo2 using the name "dem2" 
        }

        private void Demo3PlaceholderButton_Pressed(object sender, EventArgs e)
        {
            Demo3PlaceholderButton.BackgroundColor = Color.WhiteSmoke;
        }

        private void Demo3PlaceholderButton_Released(object sender, EventArgs e)
        {
            Demo3PlaceholderButton.BackgroundColor = Color.WhiteSmoke;
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

        private void InviteButton_Pressed(object sender, EventArgs e)
        {
            InviteButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void InviteButton_Released(object sender, EventArgs e)
        {
            InviteButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://calendar.google.com/calendar/b/1/r/month/2019/9/1?cid=bm1xc3JlYnVwMzUxbzJmMjczbmo3NTNqMzBAZ3JvdXAuY2FsZW5kYXIuZ29vZ2xlLmNvbQ")); 
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

        private void OfferButton_Pressed(object sender, EventArgs e)
        {
            OfferButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void OfferButton_Released(object sender, EventArgs e)
        {
            OfferButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/1BLUZ2wxI4B1pVV-SVajtmMLyt9NkD11k/view?usp=sharing")); 
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