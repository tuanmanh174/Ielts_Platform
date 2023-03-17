using DataModel.Exam;
using Ielts_Admin.Service.Exam;
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

        public async Task<IActionResult> ExamCreate(ExamCreateDTO request)
        {
            await _examApiClient.Create(request);
            return View();
        }
    }
}
