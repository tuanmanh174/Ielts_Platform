using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.School
{
    public class SchoolEditDTO
    {
        public string UPDATED_BY { get; set; }
        public string SCHOOL_NAME { get; set; }
        public string SCHOOL_CODE { get; set; }
        public string ADDRESS { get; set; }
        public int PHONE { get; set; }
        public int TEL { get; set; }
        public int CITY_ID { get; set; }
        public int SCHOOL_ID { get; set; }
    }
}
