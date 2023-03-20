using DataModel;
using DataModel.QuestionTest;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Ielts_Admin.Service.QuestionTest
{
    public class QuestionTestApiClient : IQuestionTestApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public QuestionTestApiClient(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<Response> Create(QuestionTestCreateDTO request)
        {
            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("https://localhost:44332");
            var response = await client.PostAsync("/api/questiontest/", httpContent);
            var body = await response.Content.ReadAsStringAsync();
            var res = JsonConvert.DeserializeObject<Response>(body);
            return res;
        }
    }
}
