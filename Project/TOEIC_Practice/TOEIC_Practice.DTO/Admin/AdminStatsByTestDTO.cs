using System;
using System.Data;

namespace TOEIC_Practice.DTO.Admin
{
    public class AdminStatsByTestDTO
    {
        public int TestId { get; set; }
        public int EtsYear { get; set; }
        public int TestNo { get; set; }
        public string Title { get; set; }
        public int AttemptCount { get; set; }
        public decimal AverageScore { get; set; }
        public decimal AverageAccuracy { get; set; }

        public AdminStatsByTestDTO() { }

        public AdminStatsByTestDTO(DataRow row)
        {
            TestId = row["TestId"] == DBNull.Value ? 0 : Convert.ToInt32(row["TestId"]);
            EtsYear = row["EtsYear"] == DBNull.Value ? 0 : Convert.ToInt32(row["EtsYear"]);
            TestNo = row["TestNo"] == DBNull.Value ? 0 : Convert.ToInt32(row["TestNo"]);
            Title = row["Title"] == DBNull.Value ? "" : row["Title"].ToString();
            AttemptCount = row["AttemptCount"] == DBNull.Value ? 0 : Convert.ToInt32(row["AttemptCount"]);
            AverageScore = row["AverageScore"] == DBNull.Value ? 0 : Convert.ToDecimal(row["AverageScore"]);
            AverageAccuracy = row["AverageAccuracy"] == DBNull.Value ? 0 : Convert.ToDecimal(row["AverageAccuracy"]);
        }
    }
}