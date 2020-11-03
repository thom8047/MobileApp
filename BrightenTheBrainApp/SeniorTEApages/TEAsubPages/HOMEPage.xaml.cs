using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrightenTheBrainApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HOMEPage : ContentPage
    {
        public HOMEPage()
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

        private void HButton_Pressed(object sender, EventArgs e)
        {
            HButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void HButton_Released(object sender, EventArgs e)
        {
            HButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/1H1GTmwfkh9GTVm4CZoCL7X-JWoaaDY1a/view?usp=sharing")); 
        }

        private void OButton_Pressed(object sender, EventArgs e)
        {
            OButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void OButton_Released(object sender, EventArgs e)
        {
            OButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/1_lOLruRF-3fq_00kmN4gdrs21CRxdcNE/view?usp=sharing")); 
        }

        private void MButton_Pressed(object sender, EventArgs e)
        {
            MButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void MButton_Released(object sender, EventArgs e)
        {
            MButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/1DHmP6eMkNjEQXiWN5QXmNpafVZdLkjtz/view?usp=sharing")); 
        }

        private void EButton_Pressed(object sender, EventArgs e)
        {
            EButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void EButton_Released(object sender, EventArgs e)
        {
            EButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/1onDEB1U1ab9zqOrkm6S88eqCyiYohGo9/view?usp=sharing")); 
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