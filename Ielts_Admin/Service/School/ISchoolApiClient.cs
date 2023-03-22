using DataModel;
using DataModel.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ielts_Admin.Service.School
{
    public interface ISchoolApiClient
    {
        Task<Response> Create(SchoolCreateDTO request);
        Task<Response> Put(SchoolEditDTO request);
        Task<List<SchoolGetListDTO>> Get(string keyWord, string schoolCode, int cityId);
        Task<SchoolGetListDTO> GetData(int schoolId);
    }
}
