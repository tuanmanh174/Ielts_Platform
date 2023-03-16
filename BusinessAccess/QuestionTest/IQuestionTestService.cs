using DataModel;
using DataModel.QuestionTest;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccess.QuestionTest
{
    public interface IQuestionTestService
    {
        Task<Response> Create(QuestionTestCreateDTO questionTest);
    }
}
