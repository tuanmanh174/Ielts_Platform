using DataModel;
using DataModel.AnswerWriting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ielts_Student.Service.AnswerWriting
{
    public interface IAnswerWritingApiClient
    {
        Task<AnswerWritingGetDTO> GetData(int id);
        Task<Response> Create(AnswerWritingCreateDTO request);
    }
}
