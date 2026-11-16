using System.Collections.Generic;
using System.Data;
using TOEIC_Practice.DAL.LamBai;
using TOEIC_Practice.DTO.LamBai;

namespace TOEIC_Practice.BLL.LamBai
{
    public class ReviewBLL
    {
        private readonly ReviewDAL _dal = new ReviewDAL();

        public List<AttemptReviewQuestionDTO> GetQuestions(int attemptId, int partId)
        {
            DataTable dt = _dal.GetQuestions(attemptId, partId);
            List<AttemptReviewQuestionDTO> list = new List<AttemptReviewQuestionDTO>();

            foreach (DataRow r in dt.Rows)
                list.Add(new AttemptReviewQuestionDTO(r));

            return list;
        }

        
        public List<AttemptReviewOptionDTO> GetOptions(int attemptQuestionId)
        {
            DataTable dt = _dal.GetReviewOptionsRaw(attemptQuestionId);
            var list = new List<AttemptReviewOptionDTO>();

            foreach (DataRow row in dt.Rows)
                list.Add(new AttemptReviewOptionDTO(row));

            // luôn sort theo DisplayOrder
            list.Sort((a, b) => a.DisplayOrder.CompareTo(b.DisplayOrder));
            return list;
        }

        public List<int> GetAttemptParts(int attemptId)
        {
            DataTable dt = _dal.GetAttemptParts(attemptId);
            List<int> parts = new List<int>();
            foreach (DataRow r in dt.Rows)
                parts.Add((int)r["PartId"]);
            return parts;
        }

    }
}