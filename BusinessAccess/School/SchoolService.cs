using DataAccess;
using DataModel;
using DataModel.School;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;
using System.Linq;

namespace BusinessAccess.School
{
    public class SchoolService : ISchoolService
    {
        private readonly IConfiguration _config;
        private readonly IeltsDbContext _dbContext;
        public SchoolService(IConfiguration config, IeltsDbContext dbContext)
        {
            _config = config;
            _dbContext = dbContext;
        }

        public async Task<Response> Create(SchoolCreateDTO request)
        {
            Response res = new Response();
            try
            {
                var schooObj = _dbContext.Schools.Where(x => x.SCHOOL_CODE == request.SCHOOL_CODE).FirstOrDefault();
                if (schooObj != null)
                {
                    res.Message = "Mã Code đã tồn tại";
                    res.ResponseStatus = -98;
                    return res;
                }
                DataAccess.Entities.School school = new DataAccess.Entities.School();
                school.PHONE = request.PHONE;
                school.SCHOOL_NAME = request.SCHOOL_NAME;
                school.SCHOOL_CODE = request.SCHOOL_CODE;
                school.ADDRESS = request.ADDRESS;
                school.TEL = request.TEL;
                school.CITY_ID = request.CITY_ID;
                school.CREATED_DATE = DateTime.Now;
                school.CREATED_BY = request.CREATED_BY;
                await _dbContext.AddAsync(school);
                await _dbContext.SaveChangesAsync();
                res.Message = "Thêm mới thành công";
                res.ResponseStatus = 100;
                return res;
            }
            catch (Exception ex)
            {
                ex.ToString();
                return new Response();
            }
        }


        public async Task<Response> Update(SchoolEditDTO request)
        {
            Response res = new Response();
            try
            {
                var schooObj = _dbContext.Schools.Where(x => x.SCHOOL_CODE == request.SCHOOL_CODE).FirstOrDefault();
                if (schooObj != null)
                {
                    res.Message = "Mã Code đã tồn tại";
                    res.ResponseStatus = -98;
                    return res;
                }
                var school = _dbContext.Schools.Find(request.SCHOOL_ID);
                school.PHONE = request.PHONE;
                school.SCHOOL_NAME = request.SCHOOL_NAME;
                school.SCHOOL_CODE = request.SCHOOL_CODE;
                school.ADDRESS = request.ADDRESS;
                school.TEL = request.TEL;
                school.CITY_ID = request.CITY_ID;
                school.UPDATED_DATE = DateTime.Now;
                school.UPDATED_BY = request.UPDATED_BY;
                _dbContext.Update(school);
                await _dbContext.SaveChangesAsync();
                res.Message = "Cập nhật thành công";
                res.ResponseStatus = 100;
                return res;
            }
            catch (Exception ex)
            {
                ex.ToString();
                return new Response();
            }
        }
        public async Task<List<SchoolGetListDTO>> GetList(string keyWord, string schoolCode, int cityId)
        {
            var lstSchool = _dbContext.Schools.Where(x => x.STATUS == true).ToList();
            if (keyWord != null)
            {
                lstSchool = lstSchool.Where(x => keyWord.Trim().ToLower().Contains(x.SCHOOL_NAME.Trim().ToLower())).ToList();
            }
            else if (schoolCode != null)
            {
                lstSchool = lstSchool.Where(x => schoolCode.Trim().ToLower().Contains(x.SCHOOL_CODE.Trim().ToLower())).ToList();
            }
            else if (cityId != 0)
            {
                lstSchool = lstSchool.Where(x => x.CITY_ID == cityId).ToList();
            }
            var lstSchoolDTO = new List<SchoolGetListDTO>();
            foreach (var item in lstSchool)
            {
                var ab = new SchoolGetListDTO();
                ab.PHONE = Convert.ToInt32(item.PHONE);
                ab.SCHOOL_CODE = item.SCHOOL_CODE;
                ab.SCHOOL_ID = item.SCHOOL_ID;
                ab.SCHOOL_NAME = item.SCHOOL_NAME;
                ab.ADDRESS = item.ADDRESS;
                ab.TEL = item.TEL;
                ab.CREATED_BY = item.CREATED_BY;
                ab.CREATED_DATE = Convert.ToDateTime(item.CREATED_DATE);
                lstSchoolDTO.Add(ab);
            }
            return lstSchoolDTO;
        }

        public async Task<SchoolGetListDTO> GetData(int schoolId)
        {
            var school = _dbContext.Schools.Find(schoolId);
            if (school != null)
            {
                SchoolGetListDTO ab = new SchoolGetListDTO();
                ab.CITY_ID = Convert.ToInt32(school.CITY_ID);
                ab.ADDRESS = school.ADDRESS;
                ab.PHONE = school.PHONE != null ? Convert.ToInt32(school.PHONE) : 0;
                ab.SCHOOL_NAME = school.SCHOOL_NAME;
                ab.SCHOOL_CODE = school.SCHOOL_CODE;
                ab.TEL = school.TEL;
                ab.SCHOOL_ID = schoolId;
                return ab;
            }
            else
            {
                return new SchoolGetListDTO();
            }
        }
    }
}
