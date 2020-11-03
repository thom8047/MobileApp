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
    public partial class FileCabinetPage : ContentPage
    {
        public FileCabinetPage()
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

        private void SearchEntry_SearchButtonPressed(object sender, EventArgs e)
        {
            //Will search database for entry
            // DisplayAlert("Working", "it's working:" + SearchEntry.Text, "ok");
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

        private void EducateButton_Pressed(object sender, EventArgs e)
        {
            //Will open new forms with "folders" that will show files. 
        }

        private void DemoButton_Pressed(object sender, EventArgs e)
        {
            //Will open new forms with "folders" that will show files. 
        }

        private void PresButton_Pressed(object sender, EventArgs e)
        {
            //Will open new forms that will show files. 
        }

        private void SalesButton_Pressed(object sender, EventArgs e)
        {
            //Will open new forms that will show files. 
        }

        private void PurchaseButton_Pressed(object sender, EventArgs e)
        {
            //Will open new forms that will show files. 
        }

        private void IBDButton_Pressed(object sender, EventArgs e)
        {
            //Will open new forms that will show files. 
        }
    }
}