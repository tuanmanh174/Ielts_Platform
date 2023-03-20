﻿using DataModel;
using DataModel.School;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccess.School
{
    public interface ISchoolService
    {
        Task<Response> Create(SchoolCreateDTO request);
        Task<List<SchoolGetListDTO>> GetList(string keyWord, string schoolName, string schoolCode, int cityId);
    }
}
