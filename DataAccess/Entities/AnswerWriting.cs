using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Entities
{
    public class AnswerWriting
    {
        public int Id { get; set; }
        public Guid StudentId { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
    }
}
