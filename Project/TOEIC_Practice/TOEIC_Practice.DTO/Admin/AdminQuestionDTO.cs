using System;
using System.Data;

namespace TOEIC_Practice.DTO.Admin
{
    public class AdminQuestionDTO
    {
        public int QuestionId { get; set; }
        public int GroupId { get; set; }
        public int TestId { get; set; }
        public int PartId { get; set; }
        public string QuestionText { get; set; }
        public string Explanation { get; set; }
        public int OrderInGroup { get; set; }
        public bool IsActive { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public AdminQuestionDTO() { }

        public AdminQuestionDTO(DataRow row)
        {
            QuestionId = row.Table.Columns.Contains("QuestionId") && row["QuestionId"] != DBNull.Value
                ? Convert.ToInt32(row["QuestionId"])
                : 0;

            GroupId = row.Table.Columns.Contains("GroupId") && row["GroupId"] != DBNull.Value
                ? Convert.ToInt32(row["GroupId"])
                : 0;

            TestId = row.Table.Columns.Contains("TestId") && row["TestId"] != DBNull.Value
                ? Convert.ToInt32(row["TestId"])
                : 0;

            PartId = row.Table.Columns.Contains("PartId") && row["PartId"] != DBNull.Value
                ? Convert.ToInt32(row["PartId"])
                : 0;

            QuestionText = row.Table.Columns.Contains("QuestionText") && row["QuestionText"] != DBNull.Value
                ? row["QuestionText"].ToString()
                : null;

            Explanation = row.Table.Columns.Contains("Explanation") && row["Explanation"] != DBNull.Value
                ? row["Explanation"].ToString()
                : null;

            OrderInGroup = row.Table.Columns.Contains("OrderInGroup") && row["OrderInGroup"] != DBNull.Value
                ? Convert.ToInt32(row["OrderInGroup"])
                : 0;

            IsActive = row.Table.Columns.Contains("IsActive") && row["IsActive"] != DBNull.Value
                ? Convert.ToBoolean(row["IsActive"])
                : false;

            UpdatedAt = row.Table.Columns.Contains("UpdatedAt") && row["UpdatedAt"] != DBNull.Value
                ? Convert.ToDateTime(row["UpdatedAt"])
                : (DateTime?)null;
        }
    }
}