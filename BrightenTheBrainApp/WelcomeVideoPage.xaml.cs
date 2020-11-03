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
    public partial class WelcomeVideoPage : ContentPage
    {
        public WelcomeVideoPage()
        {
            InitializeComponent();
        }

        private void LogInButton_Pressed(object sender, EventArgs e)
        {
            LogInButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private async void LogInButton_Released(object sender, EventArgs e)
        {
            LogInButton.BackgroundColor = Color.WhiteSmoke;
            int numModals = Application.Current.MainPage.Navigation.ModalStack.Count;
            for (int currModal = 0; currModal < numModals; currModal++)
            {
                await Application.Current.MainPage.Navigation.PopModalAsync(); //gets rid of all modal asyncs within the stack. over stacking leads to app crash.
            }
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