using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Student
{
    public class StudentCreateDTO
    {
        public string STUDENT_NAME { get; set; }
        public string STUDENT_CODE { get; set; }
        public int? SCHOOL_ID { get; set; }
        public int? TEL { get; set; }
        public string EMAIL { get; set; }
        public string CLASS { get; set; }
        public string PASSWORD { get; set; }
        public string CREATED_BY { get; set; }
    }
}
