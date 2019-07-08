using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace GUI.util
{
    static class QuestionService
    {

        // Post
        static public void SaveQuestion(Question question)
        {
            var client = new RestClient(@"http://localhost:3000/questions");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Accept", "application/json");
            request.RequestFormat = DataFormat.Json;
            string json = JsonConvert.SerializeObject(question);
            request.AddJsonBody(json);
            client.Execute(request);
        }

        // GET
        static public Question GetRandomQuestion()
        {
            var client = new RestClient(@"http://localhost:3000/questions");
            var request = new RestRequest(Method.GET);
            request.AddHeader("Accept", "application/json");
            IRestResponse response = client.Execute(request);
            var question = JsonConvert.DeserializeObject<Question>(response.Content);
            return question;
        }
        
        // GET
        static public Question GetRandomQuestion(string category)
        {
            var client = new RestClient(@"http://localhost:3000/questions/:category");
            var request = new RestRequest(Method.GET);
            request.AddHeader("Accept", "application/json");
            IRestResponse response = client.Execute(request);
            var question = JsonConvert.DeserializeObject<Question>(response.Content);
            return question;
        }
    }
}
