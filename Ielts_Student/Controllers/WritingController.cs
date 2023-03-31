using DataModel.AnswerWriting;
using Ielts_Student.Service.AnswerWriting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ielts_Student.Controllers
{
    public class WritingController : Controller
    {
        private readonly IAnswerWritingApiClient _answerWritingApiClient;
        private readonly IConfiguration _configuration;
        public WritingController(IAnswerWritingApiClient answerWritingApiClient, IConfiguration configuration)
        {
            _answerWritingApiClient = answerWritingApiClient;
            _configuration = configuration;
        }
        public IActionResult Part1(int id)
        {
            string code = User.Identity.GetCode();
            ViewBag.code = code;
            var data = _answerWritingApiClient.GetData(id);
            return View();
        }


        public IActionResult Part2(int id)
        {
            string code = User.Identity.GetCode();
            ViewBag.code = code;

            var data = _answerWritingApiClient.GetData(id);
            return View();
        }


        public JsonResult Create(AnswerWritingCreateDTO request)
        {
            var userId = User.Identity.GetId();
            request.StudentId = userId;
            var res = _answerWritingApiClient.Create(request);
            return Json(res);
        }

    }
}
