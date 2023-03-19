using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Exam
{
    public class ExamCreateDTO
    {
        public string EXAM_CODE { get; set; }
        public string EXAM_NAME { get; set; }
        public int? SCHOOL_ID { get; set; }
        public DateTime START_DATE { get; set; }
        public string DESCRIPTION { get; set; }
        public bool STATUS { get; set; }
        public string CREATED_BY { get; set; }
    }
}
