using System;
using System.Collections.Generic;
using System.Text;

namespace DataModel.Part
{
    public class PartCreateDTO
    {
        public string PART_CONTENT { get; set; }
        public int? FROM_NUMBER { get; set; }
        public int? TO_NUMBER { get; set; }
        public int? TEST_ID { get; set; }
        public string CREATED_BY { get; set; }
    }
}
