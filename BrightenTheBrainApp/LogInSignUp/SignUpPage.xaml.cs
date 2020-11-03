using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrightenTheBrainApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();
        }

        void OnButtonPressedSignUp(object sender, EventArgs args)
        {
            LogInButton.BackgroundColor = Color.Black;
        }

        void OnButtonReleased1(object sender, EventArgs args)
        {
            LogInButton.BackgroundColor = Color.FromHex("#2b2b2b"); //sets button color to original color in Hexadecimal. 
            // Name Input Is: NameEntry.Text + Email Input Is: EmailEntry.Text + Mentor Entry is: MentorEntry.Text 
            WelcomeVideoPage welcome = new WelcomeVideoPage(); //Creates an instance of the WelcomeVideoPage form called "welcome"
            Navigation.PushModalAsync(welcome); //Opens new WelcomeVideoPage using the name "welcome"
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