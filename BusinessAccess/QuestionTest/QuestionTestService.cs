﻿using DataAccess;
using DataModel;
using DataModel.QuestionTest;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;
using System.Linq;
using System.Globalization;

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
            catch (Exception ex)
            {
                ex.ToString();
                responseStatus.Message = "Thêm mới không thành công, vui lòng liên hệ lại với admin quản trị hệ thống";
                responseStatus.ResponseStatus = -99;
                return responseStatus;
            }

        }


        public async Task<Response> Update(int id, QuestionTestEditDTO questionTestDTO)
        {
            try
            {
                var questionTest = _dbContext.QuestionTests.Find(id);
                questionTest.TEST_TYPE = questionTestDTO.TEST_TYPE;
                questionTest.TEST_NAME = questionTestDTO.TEST_NAME;
                questionTest.NUMBER_PART = questionTestDTO.NUMBER_PART;
                questionTest.UPDATED_DATE = DateTime.Now;
                questionTest.UPDATED_BY = questionTestDTO.UPDATED_BY;
                questionTest.TEST_CODE = questionTestDTO.TEST_CODE;
                _dbContext.Update(questionTest);
                await _dbContext.SaveChangesAsync();
                responseStatus.Message = "Cập nhật thành công";
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

        public async Task<List<QuestionTestListDTO>> GetListData(string keyWord = "", string fromDate = "", string toDate = "", string testCode = "", int schoolId = 0)
        {
            var lstQuestionTest = _dbContext.QuestionTests.Where(x => x.SCHOOL_ID == schoolId).ToList();
            List<QuestionTestListDTO> lstQuestionTestDTO = new List<QuestionTestListDTO>();
            foreach (var item in lstQuestionTest)
            {
                var ab = new QuestionTestListDTO();
                ab.SCHOOL_ID = item.SCHOOL_ID;
                ab.TEST_CODE = item.TEST_CODE;
                ab.TEST_ID = item.TEST_ID;
                ab.TEST_NAME = item.TEST_NAME;
                ab.TEST_TYPE = item.TEST_TYPE;
                ab.NUMBER_PART = item.NUMBER_PART;
                ab.CREATED_BY = item.CREATED_BY;
                ab.CREATED_DATE = Convert.ToDateTime(item.CREATED_DATE);
                lstQuestionTestDTO.Add(ab);
            }
            if (keyWord != null)
            {
                lstQuestionTest = lstQuestionTest.Where(x => keyWord.ToLower().Trim().Contains(x.TEST_NAME.ToLower().Trim())).ToList();
            }
            else if (fromDate != null && toDate != null)
            {
                DateTime fd = DateTime.ParseExact(fromDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                DateTime td = DateTime.ParseExact(toDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                lstQuestionTest = lstQuestionTest.Where(x => x.CREATED_DATE >= fd && x.CREATED_DATE <= td).ToList();
            }
            else if (testCode != null)
            {
                lstQuestionTest = lstQuestionTest.Where(x => testCode.ToLower().Trim().Contains(x.TEST_CODE.Trim().ToLower())).ToList();
            }
            return lstQuestionTestDTO;
        }




        public async Task<QuestionTestListDTO> GetData(int id)
        {
            var questionTest = _dbContext.QuestionTests.Find(id);

            var ab = new QuestionTestListDTO();
            ab.SCHOOL_ID = questionTest.SCHOOL_ID;
            ab.TEST_CODE = questionTest.TEST_CODE;
            ab.TEST_ID = questionTest.TEST_ID;
            ab.TEST_NAME = questionTest.TEST_NAME;
            ab.TEST_TYPE = questionTest.TEST_TYPE;
            ab.NUMBER_PART = questionTest.NUMBER_PART;
            ab.CREATED_BY = questionTest.CREATED_BY;
            ab.CREATED_DATE = Convert.ToDateTime(questionTest.CREATED_DATE);

            return ab;
        }
    }
}
