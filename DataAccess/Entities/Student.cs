using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Entities
{
    public class Student : IdentityUser<Guid>
    {
        public int? SCHOOL_ID { get; set; }
        public int? TEL { get; set; }
        public string CLASS { get; set; }
        public string FULLNAME { get; set; }
        public string CREATED_BY { get; set; }
        public DateTime? CREATED_DATE { get; set; }
    }
}
