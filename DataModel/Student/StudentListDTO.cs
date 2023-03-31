using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Student
{
    public class StudentListDTO
    {
        public int STUDENT_ID { get; set; }
        public string STUDENT_NAME { get; set; }
        public string STUDENT_CODE { get; set; }
        public int? SCHOOL_ID { get; set; }
        public string SCHOOL_NAME { get; set; }
        public int? TEL { get; set; }
        public string EMAIL { get; set; }
        public string CLASS { get; set; }
        public string PASSWORD { get; set; }
    }
}
