using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using TestApp.Models;
using TestApp.Services;
using Xamarin.Forms;

namespace TestApp.ViewModels
{
	public class UserViewModel : INotifyPropertyChanged
    {

        IUserInfo _rest;      
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChnaged(string proprtyname)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(proprtyname));
            }
        }

        private readonly IMessageService _messageService;

        private ObservableCollection<User> _UserUser;
        public ObservableCollection<User> UserList
        {
            get
            {
                return _UserUser;
            }
            set
            {
                _UserUser = value;
                OnPropertyChnaged("UserList");
            }
        }


        private bool _IsBusy = true;
        public bool IsBusy
        {
            get
            {
                return _IsBusy;
            }
            set
            {
                _IsBusy = value;
                OnPropertyChnaged("IsBusy");
            }
        }

        private bool _IsVisible = false;
        public bool IsVisible
        {
            get
            {
                return _IsVisible;
            }
            set
            {
                _IsVisible = value;
                OnPropertyChnaged("IsVisible");
            }
        }

        public UserViewModel()
		{
            try
            {                
                _rest = DependencyService.Get<IUserInfo>();
                this._messageService = DependencyService.Get<IMessageService>();
                GetData();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }                     

        }

        //Data Fetch From API
        public async void GetData()
        {
            try
            {
                IsBusy = true;
                var result = await _rest.GetUserInfo();
                if (result != null)
                {                    
                    UserList = new ObservableCollection<User>(result);
                    IsBusy = false;
                    IsVisible = true;

                }
                else
                {
                    Console.WriteLine("null");
                    IsBusy = false;
                    IsVisible = false;
                    // Error Message Handle
                    _ = _messageService.ShowAsync("Error Message");
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                IsBusy = false;
                IsVisible = true;
            }           
            
        }
    }
}

