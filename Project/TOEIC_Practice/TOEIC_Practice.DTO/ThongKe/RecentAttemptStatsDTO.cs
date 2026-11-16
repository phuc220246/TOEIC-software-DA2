using System;
using System.Data;

namespace TOEIC_Practice.DTO.Stats
{
    public class RecentAttemptStatsDTO
    {
        public int AttemptId { get; set; }
        public int TestId { get; set; }
        public int EtsYear { get; set; }
        public int TestNo { get; set; }
        public string TestTitle { get; set; }

        public DateTime? StartedAt { get; set; }
        public DateTime? FinishedAt { get; set; }

        public int DurationSeconds { get; set; }
        public int TotalQuestions { get; set; }
        public int CorrectCount { get; set; }
        public int WrongCount { get; set; }
        public int SkippedCount { get; set; }

        public string ResultText { get; set; }
        public decimal AccuracyPercent { get; set; }
        public string PartDisplayText { get; set; }

        public RecentAttemptStatsDTO() { }

        public RecentAttemptStatsDTO(DataRow row)
        {
            AttemptId = row.Table.Columns.Contains("AttemptId") ? Convert.ToInt32(row["AttemptId"]) : 0;
            TestId = row.Table.Columns.Contains("TestId") ? Convert.ToInt32(row["TestId"]) : 0;
            EtsYear = row.Table.Columns.Contains("EtsYear") ? Convert.ToInt32(row["EtsYear"]) : 0;
            TestNo = row.Table.Columns.Contains("TestNo") ? Convert.ToInt32(row["TestNo"]) : 0;

            TestTitle = row.Table.Columns.Contains("TestTitle") && row["TestTitle"] != DBNull.Value
                ? row["TestTitle"].ToString()
                : string.Empty;

            StartedAt = row.Table.Columns.Contains("StartedAt") && row["StartedAt"] != DBNull.Value
                ? Convert.ToDateTime(row["StartedAt"])
                : (DateTime?)null;

            FinishedAt = row.Table.Columns.Contains("FinishedAt") && row["FinishedAt"] != DBNull.Value
                ? Convert.ToDateTime(row["FinishedAt"])
                : (DateTime?)null;

            DurationSeconds = row.Table.Columns.Contains("DurationSeconds") && row["DurationSeconds"] != DBNull.Value
                ? Convert.ToInt32(row["DurationSeconds"])
                : 0;

            TotalQuestions = row.Table.Columns.Contains("TotalQuestions") && row["TotalQuestions"] != DBNull.Value
                ? Convert.ToInt32(row["TotalQuestions"])
                : 0;

            CorrectCount = row.Table.Columns.Contains("CorrectCount") && row["CorrectCount"] != DBNull.Value
                ? Convert.ToInt32(row["CorrectCount"])
                : 0;

            WrongCount = row.Table.Columns.Contains("WrongCount") && row["WrongCount"] != DBNull.Value
                ? Convert.ToInt32(row["WrongCount"])
                : 0;

            SkippedCount = row.Table.Columns.Contains("SkippedCount") && row["SkippedCount"] != DBNull.Value
                ? Convert.ToInt32(row["SkippedCount"])
                : 0;

            ResultText = row.Table.Columns.Contains("ResultText") && row["ResultText"] != DBNull.Value
                ? row["ResultText"].ToString()
                : string.Empty;

            AccuracyPercent = row.Table.Columns.Contains("AccuracyPercent") && row["AccuracyPercent"] != DBNull.Value
                ? Convert.ToDecimal(row["AccuracyPercent"])
                : 0;

            PartDisplayText = row.Table.Columns.Contains("PartDisplayText") && row["PartDisplayText"] != DBNull.Value
                ? row["PartDisplayText"].ToString()
                : string.Empty;
        }

        public string AccuracyText => AccuracyPercent.ToString("0.##") + "%";
        public string StartedAtText => StartedAt.HasValue ? StartedAt.Value.ToString("dd/MM/yyyy HH:mm") : "";

        public string DurationText
        {
            get
            {
                TimeSpan ts = TimeSpan.FromSeconds(DurationSeconds);
                if (ts.Hours > 0) return ts.ToString(@"hh\:mm\:ss");
                return ts.ToString(@"mm\:ss");
            }
        }

        public string TestDisplayTitle => $"{EtsYear} - Test {TestNo}";
    }
}