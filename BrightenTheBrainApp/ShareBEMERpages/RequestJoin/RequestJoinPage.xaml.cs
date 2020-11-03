using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrightenTheBrainApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RequestJoinPage : ContentPage
    {
        public RequestJoinPage()
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

        private void WellnessButton_Pressed(object sender, EventArgs e)
        {
            WellnessButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void WellnessButton_Released(object sender, EventArgs e)
        {
            WellnessButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/1D1cfCMj9Vn8U5KO8tpvT1JRlafCynKiq/view?usp=sharing"));
        }

        private void TeamButton_Pressed(object sender, EventArgs e)
        {
            TeamButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void TeamButton_Released(object sender, EventArgs e)
        {
            TeamButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/1BLUZ2wxI4B1pVV-SVajtmMLyt9NkD11k/view?usp=sharing"));
        }

        private void ReferButton_Pressed(object sender, EventArgs e)
        {
            ReferButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void ReferButton_Released(object sender, EventArgs e)
        {
            ReferButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/1O-7_VNeaRCYs7_9ewF4kejlda7cO-Zrf/view?usp=sharing"));
        }

        private void ProdButton_Pressed(object sender, EventArgs e)
        {
            ProdButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void ProdButton_Released(object sender, EventArgs e)
        {
            ProdButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/1byFyN1pXhcrxcuKgSP4hJj_Dndmpeo56/view?usp=sharing"));
        }


        private void CloseSaleButton_Pressed(object sender, EventArgs e)
        {
            CloseSaleButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void CloseSaleButton_Released(object sender, EventArgs e)
        {
            CloseSaleButton.BackgroundColor = Color.WhiteSmoke;
            CloseSalePage closesale = new CloseSalePage(); //Creates an instance of the CloseSalePage form called "closesale"
            Navigation.PushModalAsync(closesale); //Opens new CloseSalePage using the name "closesale" 
        }

        private void NotYetButton_Pressed(object sender, EventArgs e)
        {
            NotYetButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void NotYetButton_Released(object sender, EventArgs e)
        {
            NotYetButton.BackgroundColor = Color.WhiteSmoke;
            NotYetPage notyet = new NotYetPage(); //Creates an instance of the NotYetPage form called "notyet"
            Navigation.PushModalAsync(notyet); //Opens new NotYetPage using the name "notyet"
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