using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOEIC_Practice.DTO.Admin
{
    public class AdminQuestionOptionBatchDTO
    {
        public int QuestionId { get; set; }
        public int AnswerId_A { get; set; }
        public int AnswerId_B { get; set; }
        public int AnswerId_C { get; set; }
        public int? AnswerId_D { get; set; }
    }
}
