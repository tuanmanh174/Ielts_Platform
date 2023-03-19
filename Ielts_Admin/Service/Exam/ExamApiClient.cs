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
            var response = await client.PostAsync("/api/exam/", httpContent);
            var body = await response.Content.ReadAsStringAsync();
            var exam = JsonConvert.DeserializeObject<Response>(body);
            return exam;
        }

        public async Task<List<ExamListDTO>> Get(string keyWord, string fromDate, string toDate, bool status, string examCode, int schoolId)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("https://localhost:44332");
            var response = await client.GetAsync("/api/exam/" + "keyWord=" + keyWord + "?" +
                "fromDate=" + fromDate + "?" + "toDate=" + toDate + "?" + "status=" + status + "?" + "examCode=" + examCode + "?" + "schoolId" + schoolId);
            var result = await response.Content.ReadAsStringAsync();
            List<ExamListDTO> data = JsonConvert.DeserializeObject<List<ExamListDTO>>(result);
            return data;
        }
    }
}
