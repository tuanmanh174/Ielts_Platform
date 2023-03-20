using DataAccess;
using DataModel;
using DataModel.ExamTest;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
namespace BusinessAccess.ExamTest
{
    public class ExamTestService : IExamTestService
    {
        private readonly IeltsDbContext _dbContext;
        Response responseStatus = new Response();
        public ExamTestService(IeltsDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Response> AddQuestionTestToExam(ExamTestCreateDTO questionTestDTO)
        {
            try
            {
                var questionTest = new DataAccess.Entities.ExamTest();
                questionTest.EXAM_ID = questionTestDTO.ExamId;
                questionTest.TEST_ID = questionTestDTO.TestId;
                _dbContext.Add(questionTest);
                await _dbContext.SaveChangesAsync();
                responseStatus.Message = "Thêm mới thành công";
                responseStatus.ResponseStatus = 100;
                return responseStatus;
            }
            catch (Exception ex)
            {
                ex.ToString();
                responseStatus.Message = "Thêm mới không thành công, vui lòng liên hệ lại với admin quản trị hệ thống";
                responseStatus.ResponseStatus = -99;
                return responseStatus;
            }

        }

        public async Task<List<ExamTestListDTO>> GetListExamTest(int schoolId)
        {
            var lstExamTest =  (from a in _dbContext.Exams
                               join b in _dbContext.ExamTests on a.EXAM_ID equals b.EXAM_ID
                               join c in _dbContext.QuestionTests on b.TEST_ID equals c.TEST_ID
                               where a.SCHOOL_ID == schoolId
                               select new ExamTestListDTO
                               {
                                   EXAM_ID = a.EXAM_ID,
                                   TEST_ID = Convert.ToInt32(b.TEST_ID),
                                   EXAM_NAME = a.EXAM_NAME,
                                   TEST_NAME = c.TEST_NAME,
                                   TEST_TYPE = c.TEST_TYPE
                               }).ToList();
            return lstExamTest;
        }
    }
}
