using BusinessAccess.System.Student;
using DataModel.Student;
using DataModel.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ielts_Platform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : Controller
    {

        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpPost("authenticate")]
        [AllowAnonymous]
        public async Task<IActionResult> Authenticate([FromBody] LoginRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var resultToken = await _studentService.Authenticate(request);
            return Ok(resultToken);
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] StudentCreateDTO request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var res = await _studentService.Register(request);
            return Ok(res);
        }
    }
}
