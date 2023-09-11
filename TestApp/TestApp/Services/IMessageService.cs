using System;
using System.Threading.Tasks;

namespace TestApp.Services
{
	public interface IMessageService
	{
        Task ShowAsync(string message);
    }
}

