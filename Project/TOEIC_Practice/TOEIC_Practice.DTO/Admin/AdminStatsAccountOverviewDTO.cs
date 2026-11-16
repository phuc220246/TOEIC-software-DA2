using System;
using System.Data;

namespace TOEIC_Practice.DTO.Admin
{
    public class AdminStatsAccountOverviewDTO
    {
        public int AccountId { get; set; }
        public string Username { get; set; }
        public string DisplayName { get; set; }
        public int AttemptCount { get; set; }
        public int DistinctTests { get; set; }
        public decimal AverageScore { get; set; }
        public DateTime? LastAttemptAt { get; set; }

        public AdminStatsAccountOverviewDTO() { }

        public AdminStatsAccountOverviewDTO(DataRow row)
        {
            AccountId = row["AccountId"] == DBNull.Value ? 0 : Convert.ToInt32(row["AccountId"]);
            Username = row["Username"] == DBNull.Value ? "" : row["Username"].ToString();
            DisplayName = row["DisplayName"] == DBNull.Value ? "" : row["DisplayName"].ToString();
            AttemptCount = row["AttemptCount"] == DBNull.Value ? 0 : Convert.ToInt32(row["AttemptCount"]);
            DistinctTests = row["DistinctTests"] == DBNull.Value ? 0 : Convert.ToInt32(row["DistinctTests"]);
            AverageScore = row["AverageScore"] == DBNull.Value ? 0 : Convert.ToDecimal(row["AverageScore"]);
            LastAttemptAt = row["LastAttemptAt"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["LastAttemptAt"]);
        }
    }
}