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

        public async Task<List<QuestionTestListDTO>> GetList(string keyWord, string fromDate, string toDate, string testCode, int schoolId)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("https://localhost:44332");
            var response = await client.GetAsync("/api/questiontest?" + "keyWord=" + keyWord +
                "&fromDate=" + fromDate + "&toDate=" + toDate + "&testCode=" + testCode + "&schoolId=" + schoolId);
            var result = await response.Content.ReadAsStringAsync();
            List<QuestionTestListDTO> data = JsonConvert.DeserializeObject<List<QuestionTestListDTO>>(result);
            return data;
        }
    }
}
