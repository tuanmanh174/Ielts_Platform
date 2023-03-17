using DataModel;
using DataModel.Exam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ielts_Admin.Service.Exam
{
    public interface IExamApiClient
    {
        Task<Response> Create(ExamCreateDTO exam);
        //Task<ExamListDTO> Get(string keyWord, string fromDate, string toDate, bool status, string examCode);
    }
}
