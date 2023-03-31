﻿using DataModel.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ielts_Student.Service.User
{
    public interface IUserApiClient
    {
        Task<string> Authenticate(LoginRequest request);
    }
}
