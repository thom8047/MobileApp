using BrightenTheBrain.ViewModels;
using BrightenTheBrain.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace BrightenTheBrain
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));

            Routing.RegisterRoute(nameof(Appointment), typeof(Appointment));
            Routing.RegisterRoute(nameof(Bemer), typeof(Bemer));
            Routing.RegisterRoute(nameof(Support), typeof(Support));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
