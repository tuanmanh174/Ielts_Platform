using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Entities
{
    public class QuestionTest : BaseEntity
    {
        public int TEST_ID { get; set; }
        public string TEST_NAME { get; set; }
        public string TEST_CODE { get; set; }
        public int SCHOOL_ID { get; set; }
        public int NUMBER_PART { get; set; } //số part trong mỗi kiểu thi. Ví dụ reading có 4 part
        public int TEST_TYPE { get; set; } //0: reading, 1: listening, 2: writing
    }
}
