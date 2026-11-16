using System;
using System.Data;

namespace TOEIC_Practice.DTO.Admin
{
    public class AdminQuestionOptionDTO
    {
        public int OptionId { get; set; }
        public int QuestionId { get; set; }
        public int AnswerId { get; set; }
        public string OptionLabel { get; set; }
        public int DisplayOrder { get; set; }
        public string AnswerText { get; set; }
        public bool IsCorrect { get; set; }
        public bool AnswerIsActive { get; set; }

        public AdminQuestionOptionDTO() { }

        public AdminQuestionOptionDTO(DataRow row)
        {
            OptionId = row.Table.Columns.Contains("OptionId") && row["OptionId"] != DBNull.Value
                ? Convert.ToInt32(row["OptionId"])
                : 0;

            QuestionId = row.Table.Columns.Contains("QuestionId") && row["QuestionId"] != DBNull.Value
                ? Convert.ToInt32(row["QuestionId"])
                : 0;

            AnswerId = row.Table.Columns.Contains("AnswerId") && row["AnswerId"] != DBNull.Value
                ? Convert.ToInt32(row["AnswerId"])
                : 0;

            OptionLabel = row.Table.Columns.Contains("OptionLabel") && row["OptionLabel"] != DBNull.Value
                ? row["OptionLabel"].ToString()
                : null;

            DisplayOrder = row.Table.Columns.Contains("DisplayOrder") && row["DisplayOrder"] != DBNull.Value
                ? Convert.ToInt32(row["DisplayOrder"])
                : 0;

            AnswerText = row.Table.Columns.Contains("AnswerText") && row["AnswerText"] != DBNull.Value
                ? row["AnswerText"].ToString()
                : null;

            IsCorrect = row.Table.Columns.Contains("IsCorrect") && row["IsCorrect"] != DBNull.Value
                ? Convert.ToBoolean(row["IsCorrect"])
                : false;

            AnswerIsActive = row.Table.Columns.Contains("AnswerIsActive") && row["AnswerIsActive"] != DBNull.Value
                ? Convert.ToBoolean(row["AnswerIsActive"])
                : false;
        }
    }
}