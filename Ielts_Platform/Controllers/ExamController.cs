using BusinessAccess.Exam;
using BusinessAccess.Exam;
using DataModel.Exam;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ielts_Platform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamController : ControllerBase
    {
        private readonly IExamService _examService;
        public ExamController(IExamService examService)
        {
            _examService = examService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]ExamCreateDTO examDTO)
        {
            var res = await _examService.Create(examDTO);
            return Ok(res);
        }

        [HttpGet]
        public async Task<IActionResult> Get(string keyWord, string fromDate, string toDate, bool status, string examCode)
        {
            var res = await _examService.GetListExam(keyWord, fromDate, toDate, status, examCode);
            return Ok(res);
        }

        
    }
}
