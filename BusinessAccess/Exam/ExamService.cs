using BusinessAccess.Exam;
using DataAccess;
using DataModel;
using DataModel.Exam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessAccess.Exam
{
    public class ExamService : IExamService
    {
        private readonly IeltsDbContext _dbContext;
        Response responseStatus = new Response();
        public ExamService(IeltsDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Response> Create(ExamCreateDTO exam)
        {
            try
            {
                var checkExamCode = _dbContext.Exams.Where(x => x.EXAM_CODE == exam.EXAM_CODE && x.SCHOOL_ID == exam.SCHOOL_ID).FirstOrDefault();
                if (checkExamCode != null)
                {
                    responseStatus.Message = "Mã Code đã tồn tại";
                    responseStatus.ResponseStatus = -100;
                    return responseStatus;
                }
                DataAccess.Entities.Exam _exam = new DataAccess.Entities.Exam();
                _exam.EXAM_CODE = exam.EXAM_CODE;
                _exam.EXAM_NAME = exam.EXAM_NAME;
                _exam.SCHOOL_ID = exam.SCHOOL_ID;
                _exam.START_DATE = exam.START_DATE;
                _exam.STATUS = exam.STATUS;
                _exam.DESCRIPTION = exam.DESCRIPTION;
                _exam.CREATED_DATE = DateTime.Now;
                _exam.CREATED_BY = exam.CREATED_BY;
                _dbContext.Exams.Add(_exam);
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

        public async Task<Response> Delete(int examId)
        {
            try
            {
                var exam = _dbContext.Exams.Find(examId);
                _dbContext.Remove(exam);
                await _dbContext.SaveChangesAsync();
                responseStatus.Message = "Xóa thành công";
                responseStatus.ResponseStatus = 100;
                return responseStatus;
            }
            catch (Exception ex)
            {
                ex.ToString();
                responseStatus.Message = "Xóa dữ liệu không thành công, vui lòng liên hệ lại với admin quản trị hệ thống";
                responseStatus.ResponseStatus = -99;
                return responseStatus;
            }

        }

        public async Task<ExamDTO> GetExamByID(int examId)
        {
            var examDTO = new ExamDTO();
            try
            {
                var exam = _dbContext.Exams.Find(examId);
                examDTO.STATUS = exam.STATUS;
                examDTO.START_DATE = exam.START_DATE;
                examDTO.EXAM_NAME = exam.EXAM_NAME;
                examDTO.EXAM_ID = exam.EXAM_ID;
                examDTO.EXAM_CODE = exam.EXAM_CODE;
                examDTO.DESCRIPTION = exam.DESCRIPTION;
                return examDTO;
            }
            catch (Exception ex)
            {
                ex.ToString();
                return examDTO;
            }

        }

        public async Task<List<ExamListDTO>> GetListExam(string keyWord, string fromDate, string toDate, bool status, string examCode, int schoolId)
        {
            var lstExamDTO = new List<ExamListDTO>();
            try
            {
                var lstExam = _dbContext.Exams.Where(x => x.SCHOOL_ID == schoolId && x.STATUS == true).ToList();
                if (keyWord != null)
                {
                    lstExam = lstExam.Where(x => keyWord.ToLower().Contains(x.EXAM_CODE.ToLower()) || keyWord.ToLower().Contains(x.EXAM_NAME.ToLower())).ToList();
                }
                else if (fromDate != "" && toDate != "")
                {

                }
                else if (examCode != "")
                {
                    lstExam = lstExam.Where(x => x.EXAM_CODE == examCode).ToList();
                }
                else if (status != true)
                {
                    lstExam = lstExam.Where(x => x.STATUS == status).ToList();
                }
                foreach (var item in lstExam)
                {
                    var examDTO = new ExamListDTO();
                    examDTO.DESCRIPTION = item.DESCRIPTION;
                    examDTO.EXAM_CODE = item.EXAM_CODE;
                    examDTO.EXAM_ID = item.EXAM_ID;
                    examDTO.EXAM_NAME = item.EXAM_NAME;
                    examDTO.START_DATE = item.START_DATE;
                    examDTO.STATUS = item.STATUS;
                    examDTO.SCHOOL_ID = schoolId;
                    examDTO.CREATED_BY = item.CREATED_BY;
                    examDTO.CREATED_DATE = Convert.ToDateTime(item.CREATED_DATE);
                    lstExamDTO.Add(examDTO);
                }
                return lstExamDTO;
            }
            catch (Exception ex)
            {
                ex.ToString();
                return lstExamDTO;
            }
        }

        public Task<Response> Update(ExamEditDTO exam)
        {
            throw new NotImplementedException();
        }
    }
}
