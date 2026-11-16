using System;
using System.Data;

namespace TOEIC_Practice.DTO.Stats
{
    public class StatsOverviewDTO
    {
        public int TotalSubmittedAttempts { get; set; }
        public int TotalQuestions { get; set; }
        public int TotalCorrect { get; set; }
        public int TotalWrong { get; set; }
        public int TotalSkipped { get; set; }
        public decimal AccuracyPercent { get; set; }
        public int AvgDurationSeconds { get; set; }
        public DateTime? LastSubmittedAt { get; set; }

        public StatsOverviewDTO() { }

        public StatsOverviewDTO(DataRow row)
        {
            TotalSubmittedAttempts = row.Table.Columns.Contains("TotalSubmittedAttempts") && row["TotalSubmittedAttempts"] != DBNull.Value
                ? Convert.ToInt32(row["TotalSubmittedAttempts"])
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

            AccuracyPercent = row.Table.Columns.Contains("AccuracyPercent") && row["AccuracyPercent"] != DBNull.Value
                ? Convert.ToDecimal(row["AccuracyPercent"])
                : 0;

            AvgDurationSeconds = row.Table.Columns.Contains("AvgDurationSeconds") && row["AvgDurationSeconds"] != DBNull.Value
                ? Convert.ToInt32(row["AvgDurationSeconds"])
                : 0;

            LastSubmittedAt = row.Table.Columns.Contains("LastSubmittedAt") && row["LastSubmittedAt"] != DBNull.Value
                ? Convert.ToDateTime(row["LastSubmittedAt"])
                : (DateTime?)null;
        }

        public string AccuracyText => AccuracyPercent.ToString("0.##") + "%";

        public string AvgDurationText
        {
            get
            {
                TimeSpan ts = TimeSpan.FromSeconds(AvgDurationSeconds);
                if (ts.Hours > 0) return ts.ToString(@"hh\:mm\:ss");
                return ts.ToString(@"mm\:ss");
            }
        }

        public string LastSubmittedAtText =>
            LastSubmittedAt.HasValue ? LastSubmittedAt.Value.ToString("dd/MM/yyyy HH:mm") : "";
    }
}