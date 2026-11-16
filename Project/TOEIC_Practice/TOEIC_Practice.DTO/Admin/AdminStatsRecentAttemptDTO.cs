using System;
using System.Data;

namespace TOEIC_Practice.DTO.Admin
{
    public class AdminStatsRecentAttemptDTO
    {
        public int AttemptId { get; set; }
        public int TestId { get; set; }
        public int EtsYear { get; set; }
        public int TestNo { get; set; }
        public string TestTitle { get; set; }
        public DateTime? StartedAt { get; set; }
        public DateTime? FinishedAt { get; set; }
        public decimal Score { get; set; }
        public int CorrectCount { get; set; }
        public int WrongCount { get; set; }
        public int SkippedCount { get; set; }

        public AdminStatsRecentAttemptDTO() { }

        public AdminStatsRecentAttemptDTO(DataRow row)
        {
            AttemptId = row["AttemptId"] == DBNull.Value ? 0 : Convert.ToInt32(row["AttemptId"]);
            TestId = row["TestId"] == DBNull.Value ? 0 : Convert.ToInt32(row["TestId"]);
            EtsYear = row["EtsYear"] == DBNull.Value ? 0 : Convert.ToInt32(row["EtsYear"]);
            TestNo = row["TestNo"] == DBNull.Value ? 0 : Convert.ToInt32(row["TestNo"]);
            TestTitle = row["TestTitle"] == DBNull.Value ? "" : row["TestTitle"].ToString();
            StartedAt = row["StartedAt"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["StartedAt"]);
            FinishedAt = row["FinishedAt"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["FinishedAt"]);
            Score = row["Score"] == DBNull.Value ? 0 : Convert.ToDecimal(row["Score"]);
            CorrectCount = row["CorrectCount"] == DBNull.Value ? 0 : Convert.ToInt32(row["CorrectCount"]);
            WrongCount = row["WrongCount"] == DBNull.Value ? 0 : Convert.ToInt32(row["WrongCount"]);
            SkippedCount = row["SkippedCount"] == DBNull.Value ? 0 : Convert.ToInt32(row["SkippedCount"]);
        }
    }
}