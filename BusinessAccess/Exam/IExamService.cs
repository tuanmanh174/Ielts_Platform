using DataModel;
using DataModel.Exam;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccess.Exam
{
    public interface IExamService
    {
        Task<Response> Create(ExamCreateDTO exam);
        Task<Response> Update(ExamEditDTO exam);
        Task<Response> Delete(int examId);
        Task<List<ExamListDTO>> GetListExam(string keyWord, string fromDate, string toDate, bool status, string examCode);
        Task<ExamDTO> GetExamByID(int examId);
    }
}
