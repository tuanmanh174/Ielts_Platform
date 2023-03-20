using DataModel;
using DataModel.QuestionTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ielts_Admin.Service.QuestionTest
{
    public interface IQuestionTestApiClient
    {
        Task<Response> Create(QuestionTestCreateDTO request);
        Task<List<QuestionTestListDTO>> GetList(string keyWord, string fromDate, string toDate, string testCode, int schoolId);

    }
}
