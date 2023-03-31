using BusinessAccess.AnswerWriting;
using DataModel.AnswerWriting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ielts_Platform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnswerWritingController : Controller
    {
        private readonly IAnswerWritingService _answerWritingService;
        public AnswerWritingController(IAnswerWritingService answerWritingServic)
        {
            _answerWritingService = answerWritingServic;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var res = await _answerWritingService.GetData(id);
            return Ok(res);
        }


        [HttpPost]
        public async Task<IActionResult> Post(AnswerWritingCreateDTO request)
        {
            var res = await _answerWritingService.Create(request);
            return Ok(res);
        }
    }
}
