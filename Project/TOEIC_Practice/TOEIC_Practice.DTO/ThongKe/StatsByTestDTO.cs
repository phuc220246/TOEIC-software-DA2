using System;
using System.Data;

namespace TOEIC_Practice.DTO.Stats
{
    public class StatsByTestDTO
    {
        public int TestId { get; set; }
        public int EtsYear { get; set; }
        public int TestNo { get; set; }
        public string TestTitle { get; set; }

        public int AttemptCount { get; set; }
        public int TotalQuestions { get; set; }
        public int TotalCorrect { get; set; }
        public int TotalWrong { get; set; }
        public int TotalSkipped { get; set; }

        public decimal AvgAccuracyPercent { get; set; }
        public decimal BestAccuracyPercent { get; set; }
        public DateTime? LastAttemptAt { get; set; }

        public StatsByTestDTO() { }

        public StatsByTestDTO(DataRow row)
        {
            TestId = row.Table.Columns.Contains("TestId") ? Convert.ToInt32(row["TestId"]) : 0;
            EtsYear = row.Table.Columns.Contains("EtsYear") ? Convert.ToInt32(row["EtsYear"]) : 0;
            TestNo = row.Table.Columns.Contains("TestNo") ? Convert.ToInt32(row["TestNo"]) : 0;
            TestTitle = row.Table.Columns.Contains("TestTitle") && row["TestTitle"] != DBNull.Value
                ? row["TestTitle"].ToString()
                : string.Empty;

            AttemptCount = row.Table.Columns.Contains("AttemptCount") && row["AttemptCount"] != DBNull.Value
                ? Convert.ToInt32(row["AttemptCount"])
                : 0;

            TotalQuestions = row.Table.Columns.Contains("TotalQuestions") && row["TotalQuestions"] != DBNull.Value
                ? Convert.ToInt32(row["TotalQuestions"])
                : 0;

            TotalCorrect = row.Table.Columns.Contains("TotalCorrect") && row["TotalCorrect"] != DBNull.Value
                ? Convert.ToInt32(row["TotalCorrect"])
                : 0;

            TotalWrong = row.Table.Columns.Contains("TotalWrong") && row["TotalWrong"] != DBNull.Value
                ? Convert.ToInt32(row["TotalWrong"])
                : 0;

            TotalSkipped = row.Table.Columns.Contains("TotalSkipped") && row["TotalSkipped"] != DBNull.Value
                ? Convert.ToInt32(row["TotalSkipped"])
                : 0;

            AvgAccuracyPercent = row.Table.Columns.Contains("AvgAccuracyPercent") && row["AvgAccuracyPercent"] != DBNull.Value
                ? Convert.ToDecimal(row["AvgAccuracyPercent"])
                : 0;

            BestAccuracyPercent = row.Table.Columns.Contains("BestAccuracyPercent") && row["BestAccuracyPercent"] != DBNull.Value
                ? Convert.ToDecimal(row["BestAccuracyPercent"])
                : 0;

            LastAttemptAt = row.Table.Columns.Contains("LastAttemptAt") && row["LastAttemptAt"] != DBNull.Value
                ? Convert.ToDateTime(row["LastAttemptAt"])
                : (DateTime?)null;
        }

        public string TestDisplayTitle => $"{EtsYear} - Test {TestNo}";
        public string AvgAccuracyText => AvgAccuracyPercent.ToString("0.##") + "%";
        public string BestAccuracyText => BestAccuracyPercent.ToString("0.##") + "%";
        public string LastAttemptAtText => LastAttemptAt.HasValue ? LastAttemptAt.Value.ToString("dd/MM/yyyy HH:mm") : "";
    }
}