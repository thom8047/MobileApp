using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrightenTheBrainApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddressConcernPage : ContentPage
    {
        public AddressConcernPage()
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

        private void WorkButton_Pressed(object sender, EventArgs e)
        {
            WorkButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void WorkButton_Released(object sender, EventArgs e)
        {
            WorkButton.BackgroundColor = Color.WhiteSmoke;
            DIWorkPage work = new DIWorkPage(); //Creates an instance of the DIWorkPage form called "work"
            Navigation.PushModalAsync(work); //Opens new DIWorkPage using the name "work"
        }

        private void FinancialButton_Pressed(object sender, EventArgs e)
        {
            FinancialButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void FinancialButton_Released(object sender, EventArgs e)
        {
            FinancialButton.BackgroundColor = Color.WhiteSmoke;
            FinancialPage finance = new FinancialPage(); //Creates an instance of the FinancialPage form called "finance"
            Navigation.PushModalAsync(finance); //Opens new FinancialPage using the name "finance"
        }

        private void CompanyButton_Pressed(object sender, EventArgs e)
        {
            CompanyButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void CompanyButton_Released(object sender, EventArgs e)
        {
            CompanyButton.BackgroundColor = Color.WhiteSmoke;
            CompanyPage company = new CompanyPage(); //Creates an instance of the CompanyPage form called "company"
            Navigation.PushModalAsync(company); //Opens new CompanyPage using the name "company"
        }

        private void MatterButton_Pressed(object sender, EventArgs e)
        {
            MatterButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void MatterButton_Released(object sender, EventArgs e)
        {
            MatterButton.BackgroundColor = Color.WhiteSmoke;
             ColorsPage color = new ColorsPage(); //Creates an instance of the ColorsPage form called "color"
            Navigation.PushModalAsync(color); //Opens new ColorsPage using the name "color"
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