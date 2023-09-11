using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using TestApp.Models;

namespace TestApp.Services
{
	public class UserInfo : IUserInfo
    {
        string Base_Url = "https://jsonplaceholder.typicode.com/todos";
        public async Task<List<User>> GetUserInfo()
        {            
            HttpClient client = new HttpClient();
            try
            {
                HttpResponseMessage response = await client.GetAsync(Base_Url);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<List<User>>(result);
                    return data;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                return null;
            }
         
        }
    }
}
