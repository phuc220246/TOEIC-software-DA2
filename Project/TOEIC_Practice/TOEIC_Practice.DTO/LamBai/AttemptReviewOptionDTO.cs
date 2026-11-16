using System;
using System.Data;

namespace TOEIC_Practice.DTO.LamBai
{
    public class AttemptReviewOptionDTO
    {
        public int AttemptQuestionId { get; set; }
        public string OptionLabel { get; set; }        // A/B/C/D
        public int DisplayOrder { get; set; }          // 1..4
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }
        public bool IsCorrect { get; set; }            // để tô màu đúng
        public string ChosenOptionLabel { get; set; }  // để biết user chọn gì

        public AttemptReviewOptionDTO() { }

        public AttemptReviewOptionDTO(DataRow row)
        {
            AttemptQuestionId = row.Table.Columns.Contains("AttemptQuestionId") && row["AttemptQuestionId"] != DBNull.Value ? Convert.ToInt32(row["AttemptQuestionId"]) : 0;
            OptionLabel = row.Table.Columns.Contains("OptionLabel") ? (row["OptionLabel"]?.ToString() ?? "") : "";
            DisplayOrder = row.Table.Columns.Contains("DisplayOrder") && row["DisplayOrder"] != DBNull.Value ? Convert.ToInt32(row["DisplayOrder"]) : 0;

            AnswerId = row.Table.Columns.Contains("AnswerId") && row["AnswerId"] != DBNull.Value ? Convert.ToInt32(row["AnswerId"]) : 0;
            AnswerText = row.Table.Columns.Contains("AnswerText") ? (row["AnswerText"]?.ToString() ?? "") : "";

            // IsCorrect có thể là BIT hoặc INT -> Convert.ToBoolean xử lý được
            IsCorrect = row.Table.Columns.Contains("IsCorrect") && row["IsCorrect"] != DBNull.Value && Convert.ToBoolean(row["IsCorrect"]);

            ChosenOptionLabel = row.Table.Columns.Contains("ChosenOptionLabel") ? (row["ChosenOptionLabel"] == DBNull.Value ? null : row["ChosenOptionLabel"].ToString()) : null;
        }
    }
}