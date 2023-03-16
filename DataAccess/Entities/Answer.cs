using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Entities
{
    public class Answer
    {
        public int ANSWER_ID { get; set; }
        public int QUESTION_ID { get; set; }
        public string ANSWER_CONTENT { get; set; }
        public bool? ANSWER_TRUE { get; set; }
    }
}
