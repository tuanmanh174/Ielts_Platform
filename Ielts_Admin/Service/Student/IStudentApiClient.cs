using DataModel;
using DataModel.Student;
using DataModel.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ielts_Admin.Service.Student
{
    public interface IStudentApiClient
    {
        Task<string> Authenticate(LoginRequest request);
        Task<Response> Register(StudentCreateDTO request);
    }
}
