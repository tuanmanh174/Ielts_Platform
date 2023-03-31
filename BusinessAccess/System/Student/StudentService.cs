using DataAccess;
using DataAccess.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Text;
using System.Threading.Tasks;
using DataModel.User;
using DataModel;
using System.Linq;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using DataModel.Student;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BusinessAccess.System.Student
{
    public class StudentService : IStudentService
    {
        private readonly IConfiguration _config;
        private readonly IeltsDbContext _dbContext;
        public StudentService(IConfiguration config, IeltsDbContext dbContext)
        {
            _config = config;
            _dbContext = dbContext;
        }

        public async Task<string> Authenticate(LoginRequest request)
        {
            var res = new Response();
            var hasher = new PasswordHasher<DataAccess.Entities.Student>();
            //var password = hasher.HashPassword(null, request.Password);
            try
            {
                var user = _dbContext.Students.Where(x => x.UserName == request.UserName && x.PasswordHash == request.Password).FirstOrDefault();
                if (user == null)
                {
                    res.Message = "Tài khoản không tồn tại";
                    res.ResponseStatus = -98;
                    return res.Message;
                }
                var claims = new[]
                {
                new Claim(ClaimTypes.UserData, user.UserName),
                new Claim(ClaimTypes.Name, user.FULLNAME),
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.PrimarySid, user.SCHOOL_ID.ToString()),
            };
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Token:Key"]));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(_config["Token:Issuer"],
                    _config["Token:Issuer"],
                    claims,
                    expires: DateTime.Now.AddHours(6),
                    signingCredentials: creds);

                return new JwtSecurityTokenHandler().WriteToken(token);
            }
            catch (Exception ex)
            {
                ex.ToString();
                res.Message = "Hệ thống đang lỗi, vui lòng liên hệ với admin";
                res.ResponseStatus = -99;
                return res.Message;
            }
        }

        public async Task<Response> Register(StudentCreateDTO request)
        {
            var rs = new Response();
            var hasher = new PasswordHasher<DataAccess.Entities.Student>();
            try
            {
                var _st = _dbContext.Students.Where(x => x.UserName == request.STUDENT_CODE).FirstOrDefault();
                if (_st != null)
                {
                    rs.Message = "Mã học viên đã tồn tại";
                    rs.ResponseStatus = -99;
                    return rs;
                }
                DataAccess.Entities.Student st = new DataAccess.Entities.Student();
                st.Id = Guid.NewGuid();
                st.PasswordHash = hasher.HashPassword(null, request.PASSWORD);
                st.Email = request.EMAIL;
                st.UserName = request.STUDENT_CODE;
                st.FULLNAME = request.STUDENT_NAME;
                st.TEL = request.TEL;
                st.SCHOOL_ID = request.SCHOOL_ID;
                st.CLASS = request.CLASS;
                st.CREATED_BY = request.CREATED_BY;
                st.CREATED_DATE = DateTime.Now;
                await _dbContext.Students.AddAsync(st);
                await _dbContext.SaveChangesAsync();
                rs.Message = "Thêm mới thành công";
                rs.ResponseStatus = 100;
                return rs;
            }
            catch (Exception ex)
            {
                rs.Message = "Lỗi hệ thống";
                rs.ResponseStatus = -100;
                return rs;
            }
        }

        public async Task<List<StudentListDTO>> GetListStudent(int schoolId)
        {
            var lstStudent = await (from a in _dbContext.Students
                                    join b in _dbContext.Schools on a.SCHOOL_ID equals b.SCHOOL_ID
                                    where a.SCHOOL_ID == schoolId
                                    select new StudentListDTO
                                    {
                                        CLASS = a.CLASS,
                                        EMAIL = a.Email,
                                        SCHOOL_ID = a.SCHOOL_ID,
                                        SCHOOL_NAME = b.SCHOOL_NAME,
                                        STUDENT_CODE = a.UserName,
                                        TEL = a.TEL,
                                        STUDENT_NAME = a.FULLNAME
                                    }).ToListAsync();
            return lstStudent;
        }
    }
}
