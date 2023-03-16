using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Entities
{
    public class City : BaseEntity
    {
        public int CITY_ID { get; set; }
        public string CITY_CODE { get; set; }
        public string CITY_NAME { get; set; }
    }
}
