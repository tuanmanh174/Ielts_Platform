using DataModel;
using DataModel.Part;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccess.Part
{
    public interface IPartService
    {
        Task<Response> Create(PartCreateDTO request);
    }
}
