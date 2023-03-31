using DataAccess;
using DataAccess.Entities;
using DataModel;
using DataModel.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccess.System.User
{
    public class UserService : IUserService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IConfiguration _config;
        private readonly IeltsDbContext _dbContext;
        public UserService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IConfiguration config, IeltsDbContext dbContext)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _config = config;
            _dbContext = dbContext;
        }
        public async Task<string> Authenticate(LoginRequest request)
        {
            var res = new Response();
            try
            {
                var user = _dbContext.Users.Where(x => x.UserName == request.UserName).FirstOrDefault();
                if (user == null)
                {
                    res.Message = "Tài khoản không tồn tại";
                    res.ResponseStatus = -98;
                    return res.Message;
                }
                var result = await _signInManager.PasswordSignInAsync(user, request.Password, request.RememberMe, true);
                if (!result.Succeeded)
                {
                    res.Message = "Đăng nhập không thành công";
                    res.ResponseStatus = -99;
                    return res.Message;
                }

                var roles = await _userManager.GetRolesAsync(user);
                var claims = new[]
                {
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.GivenName, user.FirstName),
                new Claim(ClaimTypes.Role, string.Join(";",roles)),
                new Claim(ClaimTypes.PrimarySid, user.SchoolId.ToString()),
                new Claim(ClaimTypes.Name, user.UserName)
            };
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Token:Key"]));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(_config["Token:Issuer"],
                    _config["Token:Issuer"],
                    claims,
                    expires: DateTime.Now.AddHours(3),
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

        public Task<bool> Register(RegisterRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<List<UserListDTO>> GetUserLists()
        {
            var userListDTO = new List<UserListDTO>();
            var lstUser = _userManager.Users;
            foreach (var item in lstUser)
            {
                var usertDTO = new UserListDTO();
                usertDTO.Email = item.Email;
                userListDTO.Add(usertDTO);
            }
            return userListDTO;

        }
    }
}
