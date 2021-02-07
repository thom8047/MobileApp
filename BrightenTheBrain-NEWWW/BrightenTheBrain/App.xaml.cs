﻿using BrightenTheBrain.Services;
using BrightenTheBrain.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrightenTheBrain
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
            SearchPage search = new SearchPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
