﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Entities
{
    public class Exam : BaseEntity
    {
        public int EXAM_ID { get; set; }
        public string EXAM_CODE { get; set; }
        public string EXAM_NAME { get; set; }
        public int? SCHOOL_ID { get; set; }
        public DateTime START_DATE { get; set; }
        public string DESCRIPTION { get; set; }
        public bool STATUS { get; set; }
    }
}
