using DataModel.Exam;
using Ielts_Admin.Service;
using Ielts_Admin.Service.Exam;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;

namespace Ielts_Admin.Controllers
{
    [Authorize]
    public class ExamController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IExamApiClient _examApiClient;

        public ExamController(ILogger<HomeController> logger, IExamApiClient examApiClient)
        {
            _logger = logger;
            _examApiClient = examApiClient;
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

        [HttpGet]
        public IActionResult Get(string keyWord, string fromDate, string toDate, bool status, string examCode)
        {
            var _schoolId = User.Identity.SchoolId();
            var schoolId = Convert.ToInt32(_schoolId);
            var result = _examApiClient.Get(keyWord, fromDate, toDate, status, examCode, schoolId);
            List<ExamListDTO> list = Task.Run(() => result).Result;
            return View(list);
        }

        public IActionResult Get()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ExamCreateDTO request)
        {
            var schoolId = User.Identity.SchoolId();
            request.SCHOOL_ID = Convert.ToInt32(schoolId);
            if (!ModelState.IsValid)
                return View(ModelState);
            var result = await _examApiClient.Create(request);
            return View(result);
        }
    }
}
