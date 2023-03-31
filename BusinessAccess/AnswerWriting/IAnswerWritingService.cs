using DataModel;
using DataModel.AnswerWriting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccess.AnswerWriting
{
    public interface IAnswerWritingService
    {
        Task<Response> Create(AnswerWritingCreateDTO request);
        Task<AnswerWritingGetDTO> GetData(string id);
    }
}
