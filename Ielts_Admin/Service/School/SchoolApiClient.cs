using DataModel;
using DataModel.School;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Ielts_Admin.Service.School
{
    public class SchoolApiClient : ISchoolApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public SchoolApiClient(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<Response> Create(SchoolCreateDTO request)
        {
            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("https://localhost:44332");
            var response = await client.PostAsync("/api/school/", httpContent);
            var body = await response.Content.ReadAsStringAsync();
            var res = JsonConvert.DeserializeObject<Response>(body);
            return res;
        }

        public async Task<Response> Put(SchoolEditDTO request)
        {
            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("https://localhost:44332");
            var response = await client.PutAsync("/api/school/", httpContent);
            var body = await response.Content.ReadAsStringAsync();
            var res = JsonConvert.DeserializeObject<Response>(body);
            return res;
        }

        public async Task<List<SchoolGetListDTO>> Get(string keyWord, string schoolCode, int cityId)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("https://localhost:44332");
            var response = await client.GetAsync("/api/school?" + "keyWord=" + keyWord +
                 "&schoolCode=" + schoolCode + "&cityId=" + cityId);
            var result = await response.Content.ReadAsStringAsync();
            List<SchoolGetListDTO> data = JsonConvert.DeserializeObject<List<SchoolGetListDTO>>(result);
            return data;
        }

        public async Task<SchoolGetListDTO> GetData(int schoolId)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("https://localhost:44332");
            var response = await client.GetAsync("/api/school/" +  schoolId);
            var result = await response.Content.ReadAsStringAsync();
            SchoolGetListDTO data = JsonConvert.DeserializeObject<SchoolGetListDTO>(result);
            return data;
        }
    }
}
