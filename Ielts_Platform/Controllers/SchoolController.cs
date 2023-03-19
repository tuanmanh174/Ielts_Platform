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
    }
}
