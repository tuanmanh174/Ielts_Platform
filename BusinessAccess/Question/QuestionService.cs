using DataAccess;
using DataModel;
using DataModel.Question;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccess.Question
{
    public class QuestionService : IQuestionService
    {
        private readonly IeltsDbContext _dbContext;
        Response responseStatus = new Response();
        public QuestionService(IeltsDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Response> Create(QuestionCreateDTO questionDTO)
        {
            try
            {
                var questionTest = new DataAccess.Entities.Question();
                questionTest.CREATED_BY = questionDTO.CREATED_BY;
                questionTest.CREATED_DATE = DateTime.Now;
                questionTest.LELVEL = questionDTO.LEVEL;
                questionTest.QUESTION_CONTENT = questionDTO.QUESTION_CONTENT;
                questionTest.QUESTION_TYPE = questionDTO.QUESTION_TYPE;
                questionTest.SCHOOL_ID = questionDTO.SCHOOL_ID;
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
    }
}
