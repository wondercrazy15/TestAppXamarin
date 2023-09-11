using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Views;
using Xamarin.Forms;

namespace TestApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        
    
        void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {
            _ = send();
        }
        public async Task send()
        {
            await Navigation.PushAsync(new UesrPage());
        }
    }
}

