﻿using Lect7.Services;
using Lect7.Views;
using Lect7.Views.MsgCenter;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lect7
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
            //MainPage = new NavigationPage(new Page1());
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
