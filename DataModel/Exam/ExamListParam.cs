
using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Exam
{
    public class ExamListParam
    {
        public string keyWord { get; set; }
        public string fromDate { get; set; }
        public string toDate { get; set; }
        public bool status { get; set; }
        public string examCode { get; set; }
        public int schoolId { get; set; }
    }
}
