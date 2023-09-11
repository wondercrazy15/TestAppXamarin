using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApp.Models;
using TestApp.ViewModels;
using Xamarin.Forms;

namespace TestApp.Views
{	
	public partial class UesrPage : ContentPage
	{
		UserViewModel userViewModel;
        public UesrPage ()
		{
			InitializeComponent ();			
            BindingContext = new UserViewModel();
            userViewModel = BindingContext as UserViewModel;
			
        }

        /// List Item Selection
        void CollectionView_SelectionChanged(System.Object sender, SelectionChangedEventArgs e)
        {            
            User user = (e.CurrentSelection.FirstOrDefault() as User);
            _ = goToUserDetailAsync(user);
        }

        public async Task goToUserDetailAsync(User user) {            
            await Navigation.PushAsync(new UserDetailPage(user));
        }
    }
}

