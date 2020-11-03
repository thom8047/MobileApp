using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace BrightenTheBrainApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DirectoryPage : ContentPage
    {
        public DirectoryPage()
        {
            InitializeComponent();
        }

        private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            //Will search database for entry
            // DisplayAlert("Working", "it's working:" + SearchEntry.Text, "ok");
        }

        private void AppointmentButton_Pressed(object sender, EventArgs e)
        {
            AppointmentButton.BackgroundColor = Color.LightGray;//helps give illusion of pressing the button in with color
        }

        private void AppointmentButton_Released(object sender, EventArgs e)
        {
            AppointmentButton.BackgroundColor = Color.FromHex("#E6E6E6");
            AppointmentPage appoint = new AppointmentPage();
            Navigation.PushModalAsync(appoint);

        }

        private void ShareBEMERButton_Pressed(object sender, EventArgs e)
        {
            ShareBEMERButton.BackgroundColor = Color.LightGray;//helps give illusion of pressing the button in with color
        }

        private void ShareBEMERButton_Released(object sender, EventArgs e)
        {
            ShareBEMERButton.BackgroundColor = Color.FromHex("#E6E6E6");
            ShareBeemerPage beem = new ShareBeemerPage(); //Creates an instance of the ShareBeemerPage form called "beem"
            Navigation.PushModalAsync(beem); //Opens new ShareBeemerPage using the name "beem" 
        }

        private void SeniorButton_Pressed(object sender, EventArgs e)
        {
            SeniorButton.BackgroundColor = Color.LightGray;//helps give illusion of pressing the button in with color
        }

        private void SeniorButton_Released(object sender, EventArgs e)
        {
            SeniorButton.BackgroundColor = Color.FromHex("#E6E6E6");
            TeaPage senior = new TeaPage(); //Creates an instance of the TeaPage form called "senior"
            Navigation.PushModalAsync(senior); //Opens new TeaPage using the name "senior"
        }

        private void QSGButton_Pressed(object sender, EventArgs e)
        {
            QSGButton.BackgroundColor = Color.Black;//helps give illusion of pressing the button in with color
        }

        private void QSGButton_Released(object sender, EventArgs e)
        {
            QSGButton.BackgroundColor = Color.FromHex("#2b2b2b");
            Launcher.OpenAsync(new Uri("https://drive.google.com/file/d/1e4vmrH2ujOJe6ws8YvW8Ki-4GA9BGgTx/view?usp=sharing")); //opens PDF link, should eventually open link provided by Database. 
        } //Launcher.OpenAsync will replace Device.OpenUri as of next update, will need to fix throughout the app. 

        private void AddConButton_Pressed(object sender, EventArgs e)
        {
            AddConButton.BackgroundColor = Color.Black;//helps give illusion of pressing the button in with color
        }

        private void AddConButton_Released(object sender, EventArgs e)
        {
            AddConButton.BackgroundColor = Color.FromHex("#2b2b2b");
            AddContactPage contact = new AddContactPage(); //Creates an instance of the AddContactPage form called "contact"
            Navigation.PushModalAsync(contact); //Opens new AddContactPage using the name "contact"
        }

        private void PresButton_Pressed(object sender, EventArgs e)
        {
            PresButton.BackgroundColor = Color.Black;//helps give illusion of pressing the button in with color
        }

        private void PresButton_Released(object sender, EventArgs e)
        {
            PresButton.BackgroundColor = Color.FromHex("#2b2b2b");
            Launcher.OpenAsync(new Uri("https://calendar.google.com/calendar/b/1/r/month/2019/9/1?cid=bm1xc3JlYnVwMzUxbzJmMjczbmo3NTNqMzBAZ3JvdXAuY2FsZW5kYXIuZ29vZ2xlLmNvbQ"));

        }

        private void FilesButton_Pressed(object sender, EventArgs e)
        {
            FilesButton.BackgroundColor = Color.Black;//helps give illusion of pressing the button in with color
        }

        private void FilesButton_Released(object sender, EventArgs e)
        {
            FilesButton.BackgroundColor = Color.FromHex("#2b2b2b");
            FileCabinetPage files = new FileCabinetPage(); //Creates an instance of the FileCabinetPage form called "files"
            Navigation.PushModalAsync(files); //Opens new FileCabinetPage using the name "files" 
        }
    }
}