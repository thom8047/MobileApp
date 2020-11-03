using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrightenTheBrainApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PitchPage : ContentPage
    {
        public PitchPage()
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

        private void TeammatesButton_Pressed(object sender, EventArgs e)
        {
            TeammatesButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void TeammatesButton_Released(object sender, EventArgs e)
        {
            TeammatesButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/1I5-nOKgx-iSjXlg88H_MtmtbEQ6fIUwt/view?usp=sharing"));
        }

        private void VVVButton_Pressed(object sender, EventArgs e)
        {
            VVVButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void VVVButton_Released(object sender, EventArgs e)
        {
            VVVButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/1K3gksXyQZX2KLWK_74WV93Ivm8chdCb0/view?usp=sharing"));
        }

        private void IBDButton_Pressed(object sender, EventArgs e)
        {
            IBDButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void IBDButton_Released(object sender, EventArgs e)
        {
            IBDButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/1kDHGW-0I6in31-bpWNF7lSh_9VUN7lF7/view"));
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