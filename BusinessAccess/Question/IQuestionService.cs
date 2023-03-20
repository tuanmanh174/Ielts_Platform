using DataModel;
using DataModel.Question;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccess.Question
{
    public interface IQuestionService
    {
        Task<Response> Create(QuestionCreateDTO request);
    }
}
