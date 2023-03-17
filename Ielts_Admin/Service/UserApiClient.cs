using DataModel.User;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Ielts_Admin.Service
{
    public class UserApiClient : IUserApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public UserApiClient(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<string> Authenticate(LoginRequest request)
        {
            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8,"application/json");
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("https://localhost:44332");
            var response = await client.PostAsync("/api/user/authenticate", httpContent);
            var token = await response.Content.ReadAsStringAsync();
            //JObject _json = JObject.Parse(token);
            //var _token = (string)json.Tr<string>("token");
            //dynamic __json = JsonConvert.DeserializeObject(token);
            var data = (JObject)JsonConvert.DeserializeObject(token);
            string __token = data["token"].Value<string>();
            return __token;
        }
    }
}
