using DataModel;
using DataModel.Student;
using DataModel.User;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccess.System.Student
{
    public interface IStudentService
    {
        Task<string> Authenticate(LoginRequest request);
        Task<Response> Register(StudentCreateDTO request);
        Task<List<StudentListDTO>> GetListStudent(int schoolId);
    }
}
