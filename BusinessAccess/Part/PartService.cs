using DataAccess;
using DataModel;
using DataModel.Part;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccess.Part
{
    public class PartService : IPartService
    {
        private readonly IeltsDbContext _dbContext;
        Response responseStatus = new Response();
        public PartService(IeltsDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Response> Create(PartCreateDTO request)
        {
            try
            {
                var lstPart = _dbContext.Parts.Where(x => x.TEST_ID == request.TEST_ID).ToList();
                var count = _dbContext.QuestionTests.Find(request.TEST_ID).NUMBER_PART;
                if (lstPart.Count >= count)
                {
                    responseStatus.Message = "Đề thi giới hạn " + lstPart.Count + " part";
                    responseStatus.ResponseStatus = -90;
                    return responseStatus;
                }
                var part = new DataAccess.Entities.Part();
                part.PART_CONTENT = request.PART_CONTENT;
                part.FROM_NUMBER = request.FROM_NUMBER;
                part.TO_NUMBER = request.TO_NUMBER;
                part.CREATED_DATE = DateTime.Now;
                part.CREATED_BY = request.CREATED_BY;
                part.TEST_ID = request.TEST_ID;
                _dbContext.Add(part);
                await _dbContext.SaveChangesAsync();
                responseStatus.Message = "Thêm mới thành công";
                responseStatus.ResponseStatus = 100;
                return responseStatus;
            }
            catch (Exception ex)
            {
                ex.ToString();
                responseStatus.Message = "Thêm mới không thành công, vui lòng liên hệ lại với admin quản trị hệ thống";
                responseStatus.ResponseStatus = -99;
                return responseStatus;
            }
        }
    }
}
