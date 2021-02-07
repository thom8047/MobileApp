using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace BrightenTheBrain.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public HomeViewModel()
        {
            Title = "Home";
            OpenAppPage = new Command(async () => await Shell.Current.GoToAsync("Appointment"));
            OpenBemerPage = new Command(async () => await Shell.Current.GoToAsync("Bemer"));
            OpenSupportPage = new Command(async () => await Shell.Current.GoToAsync("Support"));

        }

        public ICommand OpenAppPage { get; }
        public ICommand OpenBemerPage { get; }
        public ICommand OpenSupportPage { get; }

    }
}