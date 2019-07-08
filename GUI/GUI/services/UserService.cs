using GUI.models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.services
{
    public class UserService
    {
        // POST
        public static void SaveUser(User user)
        {
            var client = new RestClient(@"http://localhost:3000/users");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Accept", "application/json");
            request.RequestFormat = DataFormat.Json;
            string json = JsonConvert.SerializeObject(user);
            request.AddJsonBody(json);
            client.Execute(request);
        }

        // GET
        static public User SearchUser(string login, string password)
        {
            var client = new RestClient(@"http://localhost:3000/users");
            var request = new RestRequest(Method.GET);
            request.AddHeader("Accept", "application/json");
            IRestResponse response = client.Execute(request);
            var user = JsonConvert.DeserializeObject<User>(response.Content);
            return user;
        }
    }
}
