using System;
using System.Data;

namespace TOEIC_Practice.DTO.Admin
{
    public class AdminStatsOverviewDTO
    {
        public int TotalAccounts { get; set; }
        public int ActiveAccounts { get; set; }
        public int TotalSubmittedAttempts { get; set; }
        public int TotalUsersWithAttempts { get; set; }
        public int TotalTests { get; set; }
        public int TotalQuestions { get; set; }
        public decimal AverageScore { get; set; }

        public AdminStatsOverviewDTO() { }

        public AdminStatsOverviewDTO(DataRow row)
        {
            TotalAccounts = row["TotalAccounts"] == DBNull.Value ? 0 : Convert.ToInt32(row["TotalAccounts"]);
            ActiveAccounts = row["ActiveAccounts"] == DBNull.Value ? 0 : Convert.ToInt32(row["ActiveAccounts"]);
            TotalSubmittedAttempts = row["TotalSubmittedAttempts"] == DBNull.Value ? 0 : Convert.ToInt32(row["TotalSubmittedAttempts"]);
            TotalUsersWithAttempts = row["TotalUsersWithAttempts"] == DBNull.Value ? 0 : Convert.ToInt32(row["TotalUsersWithAttempts"]);
            TotalTests = row["TotalTests"] == DBNull.Value ? 0 : Convert.ToInt32(row["TotalTests"]);
            TotalQuestions = row["TotalQuestions"] == DBNull.Value ? 0 : Convert.ToInt32(row["TotalQuestions"]);
            AverageScore = row["AverageScore"] == DBNull.Value ? 0 : Convert.ToDecimal(row["AverageScore"]);
        }
    }
}