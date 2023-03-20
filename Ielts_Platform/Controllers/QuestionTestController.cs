using BusinessAccess.QuestionTest;
using DataModel.QuestionTest;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ielts_Platform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionTestController : Controller
    {
        private readonly IQuestionTestService _questionTestService;
        public QuestionTestController(IQuestionTestService questionTestService)
        {
            _questionTestService = questionTestService;
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody]QuestionTestCreateDTO request)
        {
            var res = await _questionTestService.Create(request);
            return Ok(res);
        }
    }
}
