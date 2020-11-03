using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrightenTheBrainApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TrainingIA : ContentPage
    {
        public TrainingIA()
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

        private void BYBProdButton_Pressed(object sender, EventArgs e)
        {
            BYBProdButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void BYBProdButton_Released(object sender, EventArgs e)
        {
            BYBProdButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/1RkJrBVleG_vGbk4mXLW5dUTS9p64LAqv/view?usp=sharing")); 
        }

        private void BusDevButton_Pressed(object sender, EventArgs e)
        {
            BusDevButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void BusDevButton_Released(object sender, EventArgs e)
        {
            BusDevButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/1RSARhVoe8MF1vmcUNVvYgbk8vR9vTQ-u/view?usp=sharing")); 
        }

        private void CommSpaceButton_Pressed(object sender, EventArgs e)
        {
            CommSpaceButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void CommSpaceButton_Released(object sender, EventArgs e)
        {
            CommSpaceButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/1VvuvwXcsZZl04F9Lk9ywIF7i-0vfgXYV/view?usp=sharing")); 
        }

        private void BEMERResButton_Pressed(object sender, EventArgs e)
        {
            BEMERResButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void BEMERResButton_Released(object sender, EventArgs e)
        {
            BEMERResButton.BackgroundColor = Color.WhiteSmoke;
            //Ask Lori about whether to keep this button on not, uncertainty last time when prompted.  
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