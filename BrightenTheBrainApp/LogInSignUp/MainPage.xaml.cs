using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace BrightenTheBrainApp
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    { //Log in page. may need a link within the logo at the top to create an "Admin page" to make changing the Database entries easy. such as: change link of entry (Int entry input) to (linkInput) probably special user/pass protexted. 
        public MainPage()
        {
            InitializeComponent();
        }

        void OnButtonPressedLog(object sender, EventArgs args)
        {
            LogInButton.BackgroundColor = Color.Black; //Makes button darker to simulate button press. 
        }

        private void SignUpText_Clicked(object sender, EventArgs e)
        {
            SignUpPage signup = new SignUpPage(); //Creates an instance of the SignUpPage form called "signup"
            Navigation.PushModalAsync(signup); //Opens new SignUpPage using the name "signup"
        }

        void OnButtonReleased1(object sender, EventArgs args)
        {
           

            LogInButton.BackgroundColor = Color.FromHex("#2b2b2b"); //sets button color to original color in Hexadecimal. 
            try //ensures neither of the entry fields are empty/null. Will only run with at least some input. Checks if entries are correct. 
            {
                string User = EmailEntry.Text.ToUpper(); //currently the "username" field, was originally meant to be email + access code below, was changed for current functionality. 
                string Access = CodeEntry.Text.ToUpper();

                if (User == "BRIGHTENYOURBEING" && Access == "BEING") //checks to see if the access code entry and User is exactly correct after being set to upper, decision by Lori to eliminate worry of capitalization. 
                {
                    DirectoryPage directorypage = new DirectoryPage(); //Creates an instance of the DirectoryPage form called "directorypage"
                    Navigation.PushModalAsync(directorypage); //Opens new DirectoryPage using the name "directorypage"
                }
                else if (User == "BRIGHTENYOURBEING" && Access != "BEING")
                {
                    DisplayAlert("Incorrect Code", "The Access Code you used was invalid", "Ok"); //structure of display alert is header, body, ok text, cancel text, or header, body, ok if only 3 entries. 
                }
                else if (User != "BRIGTENYOURBEING" && Access == "BEING")
                {
                    DisplayAlert("Incorrect User", "The Username you used was invalid", "Ok");
                }
                else
                {
                    DisplayAlert("Incorrect Login", "The Username and Access Code you used was invalid", "Ok");
                }
            }
            catch //displays an alert when at least 1 of the two entries are empty 
            {
                DisplayAlert("entry field Error", "Username and Access Code cannot be empty","Ok");
            }
        }


    }
}
