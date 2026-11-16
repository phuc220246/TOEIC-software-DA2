using System.Collections.Generic;

namespace TOEIC_Practice.DTO.LamBai
{
    public class AttemptPart7GroupDTO
    {
        public int GroupId { get; set; }
        public int GroupOrderNo { get; set; }

        public string GroupType { get; set; }

        public List<AttemptPassageDTO> Passages { get; set; }
        public List<AttemptQuestionDTO> Questions { get; set; }

        public AttemptPart7GroupDTO()
        {
            Passages = new List<AttemptPassageDTO>();
            Questions = new List<AttemptQuestionDTO>();
        }
    }
}