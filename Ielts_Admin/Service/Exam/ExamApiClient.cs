using DataModel;
using DataModel.Exam;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Ielts_Admin.Service.Exam
{
    public class ExamApiClient : IExamApiClient
    {
        IHttpClientFactory _httpClientFactory;
        public ExamApiClient(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<Response> Create(ExamCreateDTO request)
        {
            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("https://localhost:44332");
            var response = await client.PatchAsync("/api/exam/post", httpContent);
            var token = await response.Content.ReadAsStringAsync();
            var data = (JObject)JsonConvert.DeserializeObject(token);
            string __token = data["token"].Value<string>();
            return new Response();
        }

        //public async Task<ExamListDTO> Get(string keyWord, string fromDate, string toDate, bool status, string examCode)
        //{
        //    var json = JsonConvert.SerializeObject(request);
        //    var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
        //    var client = _httpClientFactory.CreateClient();
        //    client.BaseAddress = new Uri("https://localhost:44332");
        //    var response = await client.PatchAsync("/api/exam/get", httpContent);
        //    var token = await response.Content.ReadAsStringAsync();
        //    var data = (JObject)JsonConvert.DeserializeObject(token);
        //    string __token = data["token"].Value<string>();
        //    return new Response();
        //}
    }
}
