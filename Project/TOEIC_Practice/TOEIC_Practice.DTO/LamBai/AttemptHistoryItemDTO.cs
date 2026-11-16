using System;
using System.Data;

namespace TOEIC_Practice.DTO.History
{
    public class AttemptHistoryItemDTO
    {
        public int AttemptId { get; set; }
        public int AccountId { get; set; }
        public int TestId { get; set; }

        public DateTime? NgayLam { get; set; }
        public DateTime? FinishedAt { get; set; }

        public int DurationSeconds { get; set; }

        public int TotalQuestions { get; set; }
        public int CorrectCount { get; set; }
        public int WrongCount { get; set; }
        public int SkippedCount { get; set; }

        public string ResultText { get; set; }
        public string PartDisplayText { get; set; }

        public AttemptHistoryItemDTO() { }

        public AttemptHistoryItemDTO(DataRow row)
        {
            AttemptId = row.Table.Columns.Contains("AttemptId") ? Convert.ToInt32(row["AttemptId"]) : 0;
            AccountId = row.Table.Columns.Contains("AccountId") ? Convert.ToInt32(row["AccountId"]) : 0;
            TestId = row.Table.Columns.Contains("TestId") ? Convert.ToInt32(row["TestId"]) : 0;

            NgayLam = row.Table.Columns.Contains("NgayLam") && row["NgayLam"] != DBNull.Value
                ? Convert.ToDateTime(row["NgayLam"])
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

            PartDisplayText = row.Table.Columns.Contains("PartDisplayText") && row["PartDisplayText"] != DBNull.Value
                ? row["PartDisplayText"].ToString()
                : string.Empty;
        }

        public string DurationText
        {
            get
            {
                TimeSpan ts = TimeSpan.FromSeconds(DurationSeconds);
                if (ts.Hours > 0)
                    return ts.ToString(@"hh\:mm\:ss");
                return ts.ToString(@"mm\:ss");
            }
        }

        public string NgayLamText
        {
            get
            {
                return NgayLam.HasValue ? NgayLam.Value.ToString("dd/MM/yyyy HH:mm") : string.Empty;
            }
        }
    }
}