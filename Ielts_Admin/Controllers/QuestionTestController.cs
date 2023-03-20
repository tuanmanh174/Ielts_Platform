using DataModel.QuestionTest;
using Ielts_Admin.Service;
using Ielts_Admin.Service.QuestionTest;
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
    public class QuestionTestController : Controller
    {
        private readonly ILogger<QuestionTestController> _logger;
        private readonly IQuestionTestApiClient _questionTestApiClien;

        public QuestionTestController(ILogger<QuestionTestController> logger, IQuestionTestApiClient questionTestApiClien)
        {
            _logger = logger;
            _questionTestApiClien = questionTestApiClien;
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
        public async Task<IActionResult> Create(QuestionTestCreateDTO request)
        {
            var userName = User.Identity.GetName();
            var schoolId = User.Identity.SchoolId();
            request.CREATED_BY = userName;
            request.SCHOOL_ID = Convert.ToInt32(schoolId);
            if (!ModelState.IsValid)
                return View(ModelState);
            var result = await _questionTestApiClien.Create(request);
            return RedirectToAction("Get");
        }
    }
}
