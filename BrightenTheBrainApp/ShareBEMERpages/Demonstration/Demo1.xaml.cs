using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrightenTheBrainApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Demo1 : ContentPage
    {
        public Demo1()
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
            Demo1PlaceholderButton.BackgroundColor = Color.WhiteSmoke; //gives illusion that you can't press the button with release event
        }

        private void Demo1PlaceholderButton_Released(object sender, EventArgs e)
        {
            Demo1PlaceholderButton.BackgroundColor = Color.WhiteSmoke;
        }

        private void Demo2PlaceholderButton_Pressed(object sender, EventArgs e)
        {
            Demo2PlaceholderButton.BackgroundColor = Color.Black; //helps give illusion of pressing the button in with color
        }

        private void Demo2PlaceholderButton_Released(object sender, EventArgs e)
        {
            Demo2PlaceholderButton.BackgroundColor = Color.FromHex("#2b2b2b");
            Demo2 dem2 = new Demo2(); //Creates an instance of the Demo2 form called "dem2"
            Navigation.PushModalAsync(dem2); //Opens new Demo2 using the name "dem2" 
        }

        private void Demo3PlaceholderButton_Pressed(object sender, EventArgs e)
        {
            Demo3PlaceholderButton.BackgroundColor = Color.Black; //helps give illusion of pressing the button in with color
        }

        private void Demo3PlaceholderButton_Released(object sender, EventArgs e)
        {
            Demo3PlaceholderButton.BackgroundColor = Color.FromHex("#2b2b2b");
            Demo3 dem3 = new Demo3(); //Creates an instance of the Demo3 form called "dem3"
            Navigation.PushModalAsync(dem3); //Opens new Demo3 using the name "dem3" 
        }

        private void ConsentButton_Pressed(object sender, EventArgs e)
        {
            ConsentButton.BackgroundColor = Color.FromHex("#E1E1E1"); //helps give illusion of pressing the button in with color
        }

        private void ConsentButton_Released(object sender, EventArgs e)
        {
            ConsentButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://form.jotform.com/80445962406156")); 
        }

        private void PitchVVVButton_Pressed(object sender, EventArgs e)
        {
            PitchVVVButton.BackgroundColor = Color.FromHex("#E1E1E1");//helps give illusion of pressing the button in with color
        }

        private void PitchVVVButton_Released(object sender, EventArgs e)
        {
            PitchVVVButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/1K3gksXyQZX2KLWK_74WV93Ivm8chdCb0/view?usp=sharing")); 
        }

        private void StoryButton_Pressed(object sender, EventArgs e)
        {
            StoryButton.BackgroundColor = Color.FromHex("#E1E1E1");//helps give illusion of pressing the button in with color
        }

        private void StoryButton_Released(object sender, EventArgs e)
        {
            StoryButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/1KR9R-YRwcZl_AAXtBi1jjC6uYEXI_7_b/view?usp=sharing")); 
        }

        private void BloodVidButton_Pressed(object sender, EventArgs e)
        {
            BloodVidButton.BackgroundColor = Color.FromHex("#E1E1E1");//helps give illusion of pressing the button in with color
        }

        private void BloodVidButton_Released(object sender, EventArgs e)
        {
            BloodVidButton.BackgroundColor = Color.WhiteSmoke;
            DisplayAlert("required password", "password is: CARDIO", "ok", "cancel");
            Device.OpenUri(new Uri("https://drive.google.com/file/d/1MP6OIcc51XH3ciUowe_SGtXSUqNqpB14/view?usp=sharing")); 
        }

        private void IntroVidButton_Pressed(object sender, EventArgs e)
        {
            IntroVidButton.BackgroundColor = Color.FromHex("#E1E1E1");//helps give illusion of pressing the button in with color
        }

        private void IntroVidButton_Released(object sender, EventArgs e)
        {
            IntroVidButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://vimeopro.com/kimsimsby/8-minute-story"));
        }

        private void ScienceVidButton_Pressed(object sender, EventArgs e)
        {
            ScienceVidButton.BackgroundColor = Color.FromHex("#E1E1E1");//helps give illusion of pressing the button in with color
        }

        private void ScienceVidButton_Released(object sender, EventArgs e)
        {
            ScienceVidButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://www.youtube.com/watch?v=d9p2-iGMDOo&feature=youtu.be"));
        }

        private void Offer2Button_Pressed(object sender, EventArgs e)
        {
            Offer2Button.BackgroundColor = Color.FromHex("#E1E1E1");//helps give illusion of pressing the button in with color
        }

        private void Offer2Button_Released(object sender, EventArgs e)
        {
            Offer2Button.BackgroundColor = Color.WhiteSmoke;
            Demo2 dem2 = new Demo2(); //Creates an instance of the Demo2 form called "dem2"
            Navigation.PushModalAsync(dem2); //Opens new Demo2 using the name "dem2" 
        }


        void OnButtonPressedBack(object sender, EventArgs args)
        {
            BackButton.BackgroundColor = Color.Black;//helps give illusion of pressing the button in with color
        }

        void OnButtonReleasedBack(object sender, EventArgs args)
        {
            BackButton.BackgroundColor = Color.FromHex("#2b2b2b");
            Navigation.PopModalAsync();
        }
    }
}