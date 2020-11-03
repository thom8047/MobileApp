using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrightenTheBrainApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShareBeemerPage : ContentPage
    {
        public ShareBeemerPage()
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

        private void DemoButton_Pressed(object sender, EventArgs e)
        {
            DemoButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void DemoButton_Released(object sender, EventArgs e)
        {
            DemoButton.BackgroundColor = Color.WhiteSmoke;
            Demonstration demo = new Demonstration(); //Creates an instance of the Demonstration form called "demo"
            Navigation.PushModalAsync(demo); //Opens new Demonstration using the name "demo"
        }

        private void EduButton_Pressed(object sender, EventArgs e)
        {
            EduButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void EduButton_Released(object sender, EventArgs e)
        {
            EduButton.BackgroundColor = Color.WhiteSmoke;
            EducatePage edu = new EducatePage(); //Creates an instance of the EducatePage form called "edu"
            Navigation.PushModalAsync(edu); //Opens new EducatePage using the name "edu"
        }

        private void AddressConcernButton_Pressed(object sender, EventArgs e)
        {
            AddressConcernButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void AddressConcernButton_Released(object sender, EventArgs e)
        {
            AddressConcernButton.BackgroundColor = Color.WhiteSmoke;
            AddressConcernPage addcon = new AddressConcernPage(); //Creates an instance of the AddressConcernPage form called "addcon"
            Navigation.PushModalAsync(addcon); //Opens new AddressConcernPage using the name "addcon"
        }

        private void JoinButton_Pressed(object sender, EventArgs e)
        {
            JoinButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void JoinButton_Released(object sender, EventArgs e)
        {
            JoinButton.BackgroundColor = Color.WhiteSmoke;
            RequestJoinPage join = new RequestJoinPage(); //Creates an instance of the RequestJoinPage form called "join"
            Navigation.PushModalAsync(join); //Opens new RequestJoinPage using the name "join"
        }

        private void BYBStartButton_Pressed(object sender, EventArgs e)
        {
            BYBStartButton.BackgroundColor = Color.FromHex("#E1E1E1");
        }

        private void BYBStartButton_Released(object sender, EventArgs e)
        {
            BYBStartButton.BackgroundColor = Color.WhiteSmoke;
            Device.OpenUri(new Uri("https://drive.google.com/file/d/1e4vmrH2ujOJe6ws8YvW8Ki-4GA9BGgTx/view?usp=sharing"));
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