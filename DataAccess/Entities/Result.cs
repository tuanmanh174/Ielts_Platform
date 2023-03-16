using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Entities
{
    public class Result
    {
        public int RESULT_ID { get; set; }
        public int? EXAM_ID { get; set; }
        public string ANSWER { get; set; }
        public string ANSWER_TRUE { get; set; }
        public int? QUESTION_ID { get; set; }
        public int? MARK { get; set; }
    }
}
