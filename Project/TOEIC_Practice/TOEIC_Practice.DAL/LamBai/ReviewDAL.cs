using System.Data;
using System.Data.SqlClient;
using TOEIC_Practice.DAL.Helpers;

namespace TOEIC_Practice.DAL.LamBai
{
    public class ReviewDAL
    {
        public DataTable GetQuestions(int attemptId, int partId)
        {
            return DataHelper.Instance.ExecuteQuerySP(
                "sp_Attempt_Review_GetQuestions",
                new SqlParameter("@AttemptId", attemptId),
                new SqlParameter("@PartId", partId)
            );
        }

        public DataTable GetOptions(int attemptQuestionId)
        {
            return DataHelper.Instance.ExecuteQuerySP(
                "sp_Attempt_Review_GetOptions",
                new SqlParameter("@AttemptQuestionId", attemptQuestionId)
            );
        }

        public DataTable GetAttemptParts(int attemptId)
        {
            return DataHelper.Instance.ExecuteQuerySP(
                "sp_Attempt_GetAttemptParts",
                new SqlParameter("@AttemptId", attemptId)
            );
        }
        public DataTable GetReviewOptionsRaw(int attemptQuestionId)
        {
            return DataHelper.Instance.ExecuteQuerySP(
                "sp_Attempt_Review_GetOptions",
                new SqlParameter("@AttemptQuestionId", attemptQuestionId)
            );
        }
        public DataTable GetGroupPassagesRaw(int attemptId, int partId = 7)
        {
            return DataHelper.Instance.ExecuteQuerySP(
                "dbo.sp_Attempt_GetGroupPassages",
                new SqlParameter("@AttemptId", attemptId),
                new SqlParameter("@PartId", partId)
            );
        }
    }
}