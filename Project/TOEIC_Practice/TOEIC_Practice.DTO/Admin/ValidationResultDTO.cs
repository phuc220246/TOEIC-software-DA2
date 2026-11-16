using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOEIC_Practice.DTO.Admin
{
    public class ValidationResultDTO
    {
        public int QuestionId { get; set; }
        public int PartId { get; set; }
        public int ActiveAnswerCount { get; set; }
        public int CorrectCount { get; set; }
        public int OptionCount { get; set; }
        public bool IsValid { get; set; }
        public string Message { get; set; }
    }
}
