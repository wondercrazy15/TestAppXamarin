using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TestApp.Views
{	
	public partial class UserDetailPage : ContentPage
	{	
		public UserDetailPage (Models.User user)
		{
			InitializeComponent ();
			title.Text = "Title: "+user.title.ToString();
			isCompleted.Text = "Is Task Completed: "+user.completed.ToString();

        }
	}
}

