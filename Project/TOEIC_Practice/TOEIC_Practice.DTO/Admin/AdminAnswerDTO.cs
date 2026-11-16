using System;
using System.Data;

namespace TOEIC_Practice.DTO.Admin
{
    public class AdminAnswerDTO
    {
        public int AnswerId { get; set; }
        public int QuestionId { get; set; }
        public string AnswerText { get; set; }
        public bool IsCorrect { get; set; }
        public bool IsActive { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public AdminAnswerDTO() { }

        public AdminAnswerDTO(DataRow row)
        {
            AnswerId = row.Table.Columns.Contains("AnswerId") && row["AnswerId"] != DBNull.Value
                ? Convert.ToInt32(row["AnswerId"])
                : 0;

            QuestionId = row.Table.Columns.Contains("QuestionId") && row["QuestionId"] != DBNull.Value
                ? Convert.ToInt32(row["QuestionId"])
                : 0;

            AnswerText = row.Table.Columns.Contains("AnswerText") && row["AnswerText"] != DBNull.Value
                ? row["AnswerText"].ToString()
                : null;

            IsCorrect = row.Table.Columns.Contains("IsCorrect") && row["IsCorrect"] != DBNull.Value
                ? Convert.ToBoolean(row["IsCorrect"])
                : false;

            IsActive = row.Table.Columns.Contains("IsActive") && row["IsActive"] != DBNull.Value
                ? Convert.ToBoolean(row["IsActive"])
                : false;

            UpdatedAt = row.Table.Columns.Contains("UpdatedAt") && row["UpdatedAt"] != DBNull.Value
                ? Convert.ToDateTime(row["UpdatedAt"])
                : (DateTime?)null;
        }
    }
}