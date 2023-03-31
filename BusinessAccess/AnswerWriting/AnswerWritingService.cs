using DataAccess;
using DataModel;
using DataModel.AnswerWriting;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccess.AnswerWriting
{
    public class AnswerWritingService : IAnswerWritingService
    {
        private readonly IConfiguration _config;
        private readonly IeltsDbContext _dbContext;
        public AnswerWritingService(IConfiguration config, IeltsDbContext dbContext)
        {
            _config = config;
            _dbContext = dbContext;
        }

        public async Task<Response> Create(AnswerWritingCreateDTO request)
        {
            Response res = new Response();
            try
            {
                var aw = _dbContext.AnswerWritings.Where(x => x.StudentId.ToString() == request.StudentId).FirstOrDefault();
                if (aw == null)
                {
                    DataAccess.Entities.AnswerWriting st = new DataAccess.Entities.AnswerWriting();
                    st.Answer1 = request.Answer1;
                    st.Answer2 = request.Answer2;
                    st.StudentId = new Guid(request.StudentId);
                    await _dbContext.AddAsync(st);
                    await _dbContext.SaveChangesAsync();
                    res.Message = "Thêm mới thành công";
                    res.ResponseStatus = 100;
                    return res;
                }
                else
                {
                    var id = aw.Id;
                    var obj = _dbContext.AnswerWritings.Find(id);
                    obj.Answer1 = request.Answer1;
                    obj.Answer2 = request.Answer2;
                    _dbContext.Update(obj);
                    _dbContext.SaveChanges();
                    res.Message = "Thành công";
                    res.ResponseStatus = 100;
                    return res;
                }

            }
            catch (Exception ex)
            {
                ex.ToString();
                return new Response();
            }
        }

        public async Task<AnswerWritingGetDTO> GetData(string id)
        {
            var _obj = _dbContext.AnswerWritings.Where(x => x.StudentId.ToString() == id).FirstOrDefault();
            var obj = _dbContext.AnswerWritings.Find(_obj.Id);
            if (obj == null)
                return new AnswerWritingGetDTO();
            var ab = new AnswerWritingGetDTO();
            ab.Answer1 = obj.Answer1;
            ab.Answer2 = obj.Answer2;
            ab.StudentId = obj.StudentId.ToString();
            return ab;
        }
    }
}
