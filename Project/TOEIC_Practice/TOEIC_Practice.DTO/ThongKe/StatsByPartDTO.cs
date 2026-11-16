using System;
using System.Data;

namespace TOEIC_Practice.DTO.Stats
{
    public class StatsByPartDTO
    {
        public int PartId { get; set; }
        public string PartName { get; set; }
        public int TotalQuestions { get; set; }
        public int CorrectCount { get; set; }
        public int WrongCount { get; set; }
        public int SkippedCount { get; set; }
        public decimal AccuracyPercent { get; set; }

        public StatsByPartDTO() { }

        public StatsByPartDTO(DataRow row)
        {
            PartId = row.Table.Columns.Contains("PartId") ? Convert.ToInt32(row["PartId"]) : 0;
            PartName = row.Table.Columns.Contains("PartName") && row["PartName"] != DBNull.Value
                ? row["PartName"].ToString()
                : string.Empty;

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

            AccuracyPercent = row.Table.Columns.Contains("AccuracyPercent") && row["AccuracyPercent"] != DBNull.Value
                ? Convert.ToDecimal(row["AccuracyPercent"])
                : 0;
        }

        public string AccuracyText => AccuracyPercent.ToString("0.##") + "%";
    }
}