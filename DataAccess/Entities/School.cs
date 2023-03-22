using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Entities
{
    public class School : BaseEntity
    {
        public int SCHOOL_ID { get; set; }
        public string SCHOOL_NAME { get; set; }
        public string SCHOOL_CODE { get; set; }
        public string ADDRESS { get; set; }
        public int? PHONE { get; set; }
        public int? TEL { get; set; }
        public int? CITY_ID { get; set; }
        public bool STATUS { get; set; }

    }
}
