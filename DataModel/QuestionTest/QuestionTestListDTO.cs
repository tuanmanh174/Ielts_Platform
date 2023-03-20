using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.QuestionTest
{
    public class QuestionTestListDTO
    {
        public int TEST_ID { get; set; }
        public string TEST_NAME { get; set; }
        public int SCHOOL_ID { get; set; }
        public int NUMBER_PART { get; set; }
        public int TEST_TYPE { get; set; }
        public string TEST_CODE { get; set; }
        public DateTime CREATED_DATE { get; set; }
        public string CREATED_BY { get; set; }
    }
}
