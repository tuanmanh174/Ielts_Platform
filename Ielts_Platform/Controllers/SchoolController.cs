using BusinessAccess.School;
using DataModel.School;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ielts_Platform.Controllers
{
    [Route("api/[controller]")]
    public class SchoolController : Controller
    {
        private readonly ISchoolService _schoolService;
        public SchoolController(ISchoolService schoolService)
        {
            _schoolService = schoolService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] SchoolCreateDTO request)
        {
            var res = await _schoolService.Create(request);
            return Ok(res);
        }

        [HttpGet]
        public async Task<IActionResult> Get(string keyWord, string schoolCode, int cityId)
        {
            var res = await _schoolService.GetList(keyWord, schoolCode, cityId);
            return Ok(res);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] SchoolEditDTO request)
        {
            var res = await _schoolService.Update(request);
            return Ok(res);
        }

        [HttpGet]
        public async Task<IActionResult> GetData(int id)
        {
            var data = await _schoolService.GetData(id);
            return Ok(data);
        }

    }
}
