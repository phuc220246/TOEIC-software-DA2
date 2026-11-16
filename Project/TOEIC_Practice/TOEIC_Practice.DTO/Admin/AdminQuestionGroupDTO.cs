using System;
using System.Data;

namespace TOEIC_Practice.DTO.Admin
{
    public class AdminQuestionGroupDTO
    {
        public int GroupId { get; set; }
        public int TestId { get; set; }
        public int PartId { get; set; }
        public string GroupType { get; set; }
        public string AudioPath { get; set; }
        public string ImagePath { get; set; }
        public string PassageText { get; set; }
        public int OrderNo { get; set; }
        public bool IsActive { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public AdminQuestionGroupDTO() { }

        public AdminQuestionGroupDTO(DataRow row)
        {
            GroupId = row.Table.Columns.Contains("GroupId") && row["GroupId"] != DBNull.Value
                ? Convert.ToInt32(row["GroupId"])
                : 0;

            TestId = row.Table.Columns.Contains("TestId") && row["TestId"] != DBNull.Value
                ? Convert.ToInt32(row["TestId"])
                : 0;

            PartId = row.Table.Columns.Contains("PartId") && row["PartId"] != DBNull.Value
                ? Convert.ToInt32(row["PartId"])
                : 0;

            GroupType = row.Table.Columns.Contains("GroupType") && row["GroupType"] != DBNull.Value
                ? row["GroupType"].ToString()
                : null;

            AudioPath = row.Table.Columns.Contains("AudioPath") && row["AudioPath"] != DBNull.Value
                ? row["AudioPath"].ToString()
                : null;

            ImagePath = row.Table.Columns.Contains("ImagePath") && row["ImagePath"] != DBNull.Value
                ? row["ImagePath"].ToString()
                : null;

            PassageText = row.Table.Columns.Contains("PassageText") && row["PassageText"] != DBNull.Value
                ? row["PassageText"].ToString()
                : null;

            OrderNo = row.Table.Columns.Contains("OrderNo") && row["OrderNo"] != DBNull.Value
                ? Convert.ToInt32(row["OrderNo"])
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