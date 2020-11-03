using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrightenTheBrainApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NotYetPage : ContentPage
    {
        public NotYetPage()
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

        private void AskButton_Pressed(object sender, EventArgs e)
        {
            AskButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void AskButton_Released(object sender, EventArgs e)
        {
            AskButton.BackgroundColor = Color.WhiteSmoke;
            EducatePage educate = new EducatePage(); //Creates an instance of the EducatePage form called "educate"
            Navigation.PushModalAsync(educate); //Opens new EducatePage using the name "educate" 
        }

        private void ConnectButton_Pressed(object sender, EventArgs e)
        {
            ConnectButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void ConnectButton_Released(object sender, EventArgs e)
        {
            ConnectButton.BackgroundColor = Color.WhiteSmoke;
            CoffeePage coffee = new CoffeePage(); //Creates an instance of the CoffeePage form called "coffee"
            Navigation.PushModalAsync(coffee); //Opens new CoffeePage using the name "coffee" 
        }

        private void LongListButton_Pressed(object sender, EventArgs e)
        {
            LongListButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void LongListButton_Released(object sender, EventArgs e)
        {
            LongListButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/1wIEovpq0r7QpTIo-5p6D5zT4P8XgJieE/view?usp=sharing"));
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

        private void CommittedButton_Pressed(object sender, EventArgs e)
        {
             CommittedButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void CommittedButton_Released(object sender, EventArgs e)
        {
            CommittedButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/1ArpRQI8r1xh6rJxMWQtb4gFLWmOzckKa/view?usp=sharing"));
        }
    }
}