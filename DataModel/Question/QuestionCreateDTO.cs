using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Question
{
    public class QuestionCreateDTO
    {
        public int QUESTION_TYPE { get; set; }
        public string QUESTION_CONTENT { get; set; }
        public int LEVEL { get; set; }
        public string CREATED_BY { get; set; }
        public int SCHOOL_ID { get; set; }

    }
}
