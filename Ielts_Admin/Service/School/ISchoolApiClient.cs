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
    }
}
