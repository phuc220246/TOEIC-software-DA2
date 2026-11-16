using System;
using System.Data;

namespace TOEIC_Practice.DTO.LamBai
{
    public class AttemptSummaryDTO
    {
        public int AttemptId { get; set; }
        public int AccountId { get; set; }
        public int TestId { get; set; }
        public byte Status { get; set; }

        public int? TimeLimitMinutes { get; set; }
        public int? Score { get; set; }

        public DateTime StartedAt { get; set; }
        public DateTime? FinishedAt { get; set; }
        public int? DurationSeconds { get; set; }

        public int TotalQuestions { get; set; }
        public int CorrectCount { get; set; }
        public int WrongCount { get; set; }
        public int SkippedCount { get; set; }

        public AttemptSummaryDTO() { }

        public AttemptSummaryDTO(DataRow row)
        {
            AttemptId = (int)row["AttemptId"];
            AccountId = (int)row["AccountId"];
            TestId = (int)row["TestId"];
            Status = (byte)row["Status"];

            TimeLimitMinutes = row["TimeLimitMinutes"] == DBNull.Value ? (int?)null : (int)row["TimeLimitMinutes"];
            Score = row["Score"] == DBNull.Value ? (int?)null : (int)row["Score"];

            StartedAt = (DateTime)row["StartedAt"];
            FinishedAt = row["FinishedAt"] == DBNull.Value ? (DateTime?)null : (DateTime)row["FinishedAt"];
            DurationSeconds = row["DurationSeconds"] == DBNull.Value ? (int?)null : (int)row["DurationSeconds"];

            TotalQuestions = (int)row["TotalQuestions"];
            CorrectCount = (int)row["CorrectCount"];
            WrongCount = (int)row["WrongCount"];
            SkippedCount = (int)row["SkippedCount"];
        }
    }
}