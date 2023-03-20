using BusinessAccess.ExamTest;
using DataModel.ExamTest;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Ielts_Platform.Controllers
{
    [Route("api/[controller]")]

    public class ExamTestController : Controller
    {

        private readonly IExamTestService _examTestService;
        public ExamTestController(IExamTestService examTestService)
        {
            _examTestService = examTestService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]ExamTestCreateDTO request)
        {
            var res = await _examTestService.AddQuestionTestToExam(request);
            return Ok(res);
        }
    }
}
