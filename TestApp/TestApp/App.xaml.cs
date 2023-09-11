using System;
using TestApp.Services;
using TestApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestApp
{
    public partial class App : Application
    {
        public App ()
        {
            InitializeComponent();
            DependencyService.Register<IUserInfo, UserInfo>();
            DependencyService.Register<IMessageService,MessageService>();
            MainPage = new NavigationPage(new UesrPage());
            //MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}

