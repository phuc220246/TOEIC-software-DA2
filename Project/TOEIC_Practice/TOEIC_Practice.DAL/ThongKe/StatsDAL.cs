using System.Data;
using System.Data.SqlClient;
using TOEIC_Practice.DAL.Helpers;

namespace TOEIC_Practice.DAL.Stats
{
    public class StatsDAL
    {
        public DataTable GetOverviewByAccount(int accountId)
        {
            return DataHelper.Instance.ExecuteQuerySP(
                "dbo.sp_Stats_GetOverviewByAccount",
                new SqlParameter("@AccountId", accountId)
            );
        }

        public DataTable GetByPart(int accountId)
        {
            return DataHelper.Instance.ExecuteQuerySP(
                "dbo.sp_Stats_GetByPart",
                new SqlParameter("@AccountId", accountId)
            );
        }

        public DataTable GetByTest(int accountId)
        {
            return DataHelper.Instance.ExecuteQuerySP(
                "dbo.sp_Stats_GetByTest",
                new SqlParameter("@AccountId", accountId)
            );
        }

        public DataTable GetRecentAttempts(int accountId, int topN = 10)
        {
            return DataHelper.Instance.ExecuteQuerySP(
                "dbo.sp_Stats_GetRecentAttempts",
                new SqlParameter("@AccountId", accountId),
                new SqlParameter("@TopN", topN)
            );
        }
    }
}