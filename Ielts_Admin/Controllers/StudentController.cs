using DataModel.Student;
using Ielts_Admin.Service;
using Ielts_Admin.Service.Student;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ielts_Admin.Controllers
{
    [Authorize]
    public class StudentController : Controller
    {

        private readonly IStudentApiClient _studentApiClient;
        private readonly IConfiguration _configuration;
        public StudentController(IStudentApiClient studentApiClient, IConfiguration configuration)
        {
            _studentApiClient = studentApiClient;
            _configuration = configuration;
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> Register(StudentCreateDTO request)
        {
            var userName = User.Identity.GetName();
            var schoolId = User.Identity.SchoolId();
            request.CREATED_BY = userName;
            request.SCHOOL_ID = Convert.ToInt32(schoolId);
            var result = await _studentApiClient.Register(request);
            return Json(result);
        }

    }
}
