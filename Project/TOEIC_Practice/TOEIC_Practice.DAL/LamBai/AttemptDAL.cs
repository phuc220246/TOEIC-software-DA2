using System;
using System.Data;
using System.Data.SqlClient;
using TOEIC_Practice.DAL.Helpers;

namespace TOEIC_Practice.DAL.LamBai
{
    public class AttemptDAL
    {
        public int StartAttempt(int accountId, int testId, string partIdsCsv, int? timeLimitMinutes)
        {
            DataTable dt = DataHelper.Instance.ExecuteQuerySP(
                "dbo.sp_Attempt_Start",
                new SqlParameter("@AccountId", accountId),
                new SqlParameter("@TestId", testId),
                new SqlParameter("@PartIdsCsv", partIdsCsv ?? "5"),
                new SqlParameter("@TimeLimitMinutes", (object)timeLimitMinutes ?? DBNull.Value)
            );

            if (dt.Rows.Count == 0)
                throw new Exception("Không tạo được Attempt (sp_Attempt_Start không trả về AttemptId).");

            return Convert.ToInt32(dt.Rows[0]["AttemptId"]);
        }

        public DataTable GetQuestionListRaw(int attemptId)
        {
            return DataHelper.Instance.ExecuteQuerySP(
            "sp_Attempt_GetQuestionListWithOptions",
            new SqlParameter("@AttemptId", attemptId)
        );
        }

        public void SaveAnswer(int attemptQuestionId, string optionLabel)
        {
            // sp_Attempt_SaveAnswer có MERGE nên dùng NonQuery hoặc Query đều được.
            DataHelper.Instance.ExecuteNonQuerySP(
                "dbo.sp_Attempt_SaveAnswer",
                new SqlParameter("@AttemptQuestionId", attemptQuestionId),
                new SqlParameter("@ChosenOptionLabel", (object)optionLabel ?? DBNull.Value)
            );
        }

        public DataTable SubmitAttemptRaw(int attemptId)
        {
            return DataHelper.Instance.ExecuteQuerySP(
                "dbo.sp_Attempt_Submit",
                new SqlParameter("@AttemptId", attemptId)
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