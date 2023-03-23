using DataModel.School;
using Ielts_Admin.Service;
using Ielts_Admin.Service.School;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ielts_Admin.Controllers
{
    [Authorize]
    public class SchoolController : Controller
    {

        private readonly ILogger<SchoolController> _logger;
        private readonly ISchoolApiClient _schoolApiClient;

        public SchoolController(ILogger<SchoolController> logger, ISchoolApiClient schoolApiClient)
        {
            _logger = logger;
            _schoolApiClient = schoolApiClient;
        }
        public IActionResult Index()
        {
            return View();
        }



        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(SchoolCreateDTO request)
        {
            var userName = User.Identity.GetName();
            request.CREATED_BY = userName;
            if (!ModelState.IsValid)
                return View(ModelState);
            var result = await _schoolApiClient.Create(request);
            return RedirectToAction("Get");
        }


        [HttpPut]
        public async Task<JsonResult> Update(SchoolEditDTO request)
        {
            var userName = User.Identity.GetName();
            request.UPDATED_BY = userName;
            var result = await _schoolApiClient.Put(request);
            return Json(result);
        }

        public IActionResult Get()
        {
            var _schoolId = User.Identity.SchoolId();
            var schoolId = Convert.ToInt32(_schoolId);
            var result = _schoolApiClient.Get("", "", 0);
            List<SchoolGetListDTO> list = Task.Run(() => result).Result;
            return View(list);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var result = _schoolApiClient.GetData(id);
            SchoolGetListDTO data = Task.Run(() => result).Result;
            return View(data);
        }
    }
}
