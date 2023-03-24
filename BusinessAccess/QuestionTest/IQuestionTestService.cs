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
        Task<Response> Update(int id, QuestionTestEditDTO questionTestDTO);
        Task<List<QuestionTestListDTO>> GetListData(string keyWord, string fromDate, string toDate, string testCode, int schoolId);
        Task<QuestionTestListDTO> GetData(int id);
    }
}
