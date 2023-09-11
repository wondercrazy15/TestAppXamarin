using System;
using System.Threading.Tasks;

namespace TestApp.Services
{
	public class MessageService : IMessageService
    {
        public async Task ShowAsync(string errormsg)
        {
            await App.Current.MainPage.DisplayAlert("Test App", errormsg, "Ok");
        }
    }
}

