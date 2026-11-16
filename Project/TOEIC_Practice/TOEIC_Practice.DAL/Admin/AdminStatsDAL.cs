using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TOEIC_Practice.DAL.Helpers;
using TOEIC_Practice.DTO.Admin;

namespace TOEIC_Practice.DAL.Admin
{
    public class AdminStatsDAL
    {
        public AdminStatsOverviewDTO GetOverview()
        {
            DataTable dt = DataHelper.Instance.ExecuteQuerySP("sp_Admin_Stats_GetOverview");
            if (dt.Rows.Count == 0) return new AdminStatsOverviewDTO();
            return new AdminStatsOverviewDTO(dt.Rows[0]);
        }

        public List<AdminStatsPartAccuracyDTO> GetAccuracyByPart()
        {
            DataTable dt = DataHelper.Instance.ExecuteQuerySP("sp_Admin_Stats_GetAccuracyByPart");
            List<AdminStatsPartAccuracyDTO> list = new List<AdminStatsPartAccuracyDTO>();

            foreach (DataRow row in dt.Rows)
                list.Add(new AdminStatsPartAccuracyDTO(row));

            return list;
        }

        public List<AdminStatsByTestDTO> GetByTest()
        {
            DataTable dt = DataHelper.Instance.ExecuteQuerySP("sp_Admin_Stats_GetByTest");
            List<AdminStatsByTestDTO> list = new List<AdminStatsByTestDTO>();

            foreach (DataRow row in dt.Rows)
                list.Add(new AdminStatsByTestDTO(row));

            return list;
        }

        public AdminStatsAccountOverviewDTO GetOverviewByAccount(int accountId)
        {
            DataTable dt = DataHelper.Instance.ExecuteQuerySP(
                "sp_Admin_Stats_GetOverviewByAccount",
                new SqlParameter("@AccountId", accountId)
            );

            if (dt.Rows.Count == 0) return new AdminStatsAccountOverviewDTO();
            return new AdminStatsAccountOverviewDTO(dt.Rows[0]);
        }

        public List<AdminStatsPartAccuracyDTO> GetAccuracyByPartByAccount(int accountId)
        {
            DataTable dt = DataHelper.Instance.ExecuteQuerySP(
                "sp_Admin_Stats_GetAccuracyByPartByAccount",
                new SqlParameter("@AccountId", accountId)
            );

            List<AdminStatsPartAccuracyDTO> list = new List<AdminStatsPartAccuracyDTO>();
            foreach (DataRow row in dt.Rows)
                list.Add(new AdminStatsPartAccuracyDTO(row));

            return list;
        }

        public List<AdminStatsRecentAttemptDTO> GetRecentAttemptsByAccount(int accountId)
        {
            DataTable dt = DataHelper.Instance.ExecuteQuerySP(
                "sp_Admin_Stats_GetRecentAttemptsByAccount",
                new SqlParameter("@AccountId", accountId)
            );

            List<AdminStatsRecentAttemptDTO> list = new List<AdminStatsRecentAttemptDTO>();
            foreach (DataRow row in dt.Rows)
                list.Add(new AdminStatsRecentAttemptDTO(row));

            return list;
        }
    }
}