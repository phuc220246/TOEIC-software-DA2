using System.Data;
using System.Data.SqlClient;
using TOEIC_Practice.DAL.Helpers;

namespace TOEIC_Practice.DAL.History
{
    public class HistoryDAL
    {
        public DataTable GetTestHeader(int testId)
        {
            return DataHelper.Instance.ExecuteQuerySP(
                "dbo.sp_History_GetTestHeader",
                new SqlParameter("@TestId", testId)
            );
        }

        public DataTable GetAttemptsByAccountAndTest(int accountId, int testId)
        {
            return DataHelper.Instance.ExecuteQuerySP(
                "dbo.sp_History_GetAttemptsByAccountAndTest",
                new SqlParameter("@AccountId", accountId),
                new SqlParameter("@TestId", testId)
            );
        }

        public DataTable GetAttemptParts(int attemptId)
        {
            return DataHelper.Instance.ExecuteQuerySP(
                "dbo.sp_History_GetAttemptParts",
                new SqlParameter("@AttemptId", attemptId)
            );
        }
    }
}