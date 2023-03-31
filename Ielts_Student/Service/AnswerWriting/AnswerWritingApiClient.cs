using DataModel;
using DataModel.AnswerWriting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Ielts_Student.Service.AnswerWriting
{
    public class AnswerWritingApiClient : IAnswerWritingApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public AnswerWritingApiClient(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<AnswerWritingGetDTO> GetData(int id)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("https://localhost:44332");
            var response = await client.GetAsync("/api/answerwriting/" + id);
            var result = await response.Content.ReadAsStringAsync();
            AnswerWritingGetDTO data = JsonConvert.DeserializeObject<AnswerWritingGetDTO>(result);
            return data;
        }

        public async Task<Response> Create(AnswerWritingCreateDTO request)
        {
            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("https://localhost:44332");
            var response = await client.PostAsync("/api/answerwriting/", httpContent);
            var body = await response.Content.ReadAsStringAsync();
            var res = JsonConvert.DeserializeObject<Response>(body);
            return res;
        }
    }
}
