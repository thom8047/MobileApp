using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrightenTheBrainApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddContactPage : ContentPage
    {
        public AddContactPage()
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

        private void AddButton_Pressed(object sender, EventArgs e)
        {
            AddButton.BackgroundColor = Color.Black; //Makes button darker to simulate button press. 
        }

        private void AddButton_Released(object sender, EventArgs e)
        {
            AddButton.BackgroundColor = Color.FromHex("#2b2b2b"); //sets button color to original color in Hexadecimal. 
            if (ActivationSlider.IsToggled == true)
            { 
            DisplayAlert("Alert Header", " Account is Activated", "OK Text", "Cancel Text");
            }
            else
            {
                DisplayAlert("Alert Header", " Account is NOT Activated", "OK Text", "Cancel Text");
            }

            //opens confirmation screen with passed values for name, number, email, where they live, group, priority, addition, activation
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