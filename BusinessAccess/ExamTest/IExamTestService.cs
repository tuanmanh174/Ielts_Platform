using DataModel;
using DataModel.ExamTest;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccess.ExamTest
{
    //Thêm đề thi vào trong kỳ thi
    public interface IExamTestService
    {
        Task<Response> AddQuestionTestToExam(ExamTestCreateDTO request);
    }
}
