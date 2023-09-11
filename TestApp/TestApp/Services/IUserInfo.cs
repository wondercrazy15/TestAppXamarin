using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TestApp.Models;

namespace TestApp.Services
{
	public interface IUserInfo
	{
        Task<List<User>> GetUserInfo();
    }
}

