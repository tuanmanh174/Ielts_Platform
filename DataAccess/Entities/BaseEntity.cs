using System;

namespace DataAccess.Entities
{
    public class BaseEntity
    {
        public DateTime? CREATED_DATE { get; set; }
        public string CREATED_BY { get; set; }
        public DateTime? UPDATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
    }
}
