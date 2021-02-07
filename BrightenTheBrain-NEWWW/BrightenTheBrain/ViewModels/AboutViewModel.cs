using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace BrightenTheBrain.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("http://www.brightenthebrain.com/"));
            OpenHomePage = new Command(async () => await Shell.Current.GoToAsync("HomePage"));

        }

        public ICommand OpenWebCommand { get; }
        public ICommand OpenHomePage { get; }
    }
}