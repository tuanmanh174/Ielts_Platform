using DataModel;
using DataModel.Student;
using DataModel.User;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Ielts_Admin.Service.Student
{
    public class StudentApiClient : IStudentApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public StudentApiClient(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<string> Authenticate(LoginRequest request)
        {
            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("https://localhost:44332");
            var response = await client.PostAsync("/api/student/authenticate", httpContent);
            var token = await response.Content.ReadAsStringAsync();
            return token;
        }

        public async Task<Response> Register(StudentCreateDTO request)
        {
            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("https://localhost:44332");
            var response = await client.PostAsync("/api/student/register", httpContent);
            var body = await response.Content.ReadAsStringAsync();
            var res = JsonConvert.DeserializeObject<Response>(body);
            return res;
        }
    }
}
