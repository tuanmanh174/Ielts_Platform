using DataAccess;
using DataModel;
using DataModel.QuestionTest;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;
namespace BusinessAccess.QuestionTest
{
    public class QuestionTestService : IQuestionTestService
    {
        private readonly IeltsDbContext _dbContext;
        Response responseStatus = new Response();
        public QuestionTestService(IeltsDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Response> Create(QuestionTestCreateDTO questionTestDTO)
        {
            try
            {
                var questionTest = new DataAccess.Entities.QuestionTest();
                questionTest.TEST_TYPE = questionTestDTO.TEST_TYPE;
                questionTest.TEST_NAME = questionTestDTO.TEST_NAME;
                questionTest.NUMBER_PART = questionTestDTO.NUMBER_PART;
                questionTest.CREATED_DATE = DateTime.Now;
                questionTest.CREATED_BY = questionTestDTO.CREATED_BY;
                questionTest.SCHOOL_ID = questionTestDTO.SCHOOL_ID;
                questionTest.TEST_CODE = questionTestDTO.TEST_CODE;
                _dbContext.Add(questionTest);
                await _dbContext.SaveChangesAsync();
                responseStatus.Message = "Thêm mới thành công";
                responseStatus.ResponseStatus = 100;
                return responseStatus;
            }
            catch(Exception ex)
            {
                ex.ToString();
                responseStatus.Message = "Thêm mới không thành công, vui lòng liên hệ lại với admin quản trị hệ thống";
                responseStatus.ResponseStatus = -99;
                return responseStatus;
            }
            
        }
    }
}
