using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrightenTheBrainApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LISTPage : ContentPage
    {
        public LISTPage()
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

        private void ListenButton_Pressed(object sender, EventArgs e)
        {
            ListenButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void ListenButton_Released(object sender, EventArgs e)
        {
            ListenButton.BackgroundColor = Color.WhiteSmoke;
            CoffeePage coffee = new CoffeePage();
            Navigation.PushModalAsync(coffee);
        }

        private void InfoButton_Pressed(object sender, EventArgs e)
        {
            InfoButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void InfoButton_Released(object sender, EventArgs e)
        {
            InfoButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/1cxp7kbDMgIr0VNdb35PHIzWQUCk3XeOn/view?usp=sharing"));
        }

        private void ShareButton_Pressed(object sender, EventArgs e)
        {
            ShareButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void ShareButton_Released(object sender, EventArgs e)
        {
            ShareButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/1sIKcdBXOBCTchQzzOenBxmvt5I2hCFxV/view?usp=sharing"));
        }

        private void TeamButton_Pressed(object sender, EventArgs e)
        {
            TeamButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void TeamButton_Released(object sender, EventArgs e)
        {
            TeamButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/1I5-nOKgx-iSjXlg88H_MtmtbEQ6fIUwt/view?usp=sharing"));
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