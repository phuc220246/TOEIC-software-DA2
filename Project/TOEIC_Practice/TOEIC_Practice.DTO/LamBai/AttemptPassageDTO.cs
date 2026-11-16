using System;
using System.Data;

namespace TOEIC_Practice.DTO.LamBai
{
    public class AttemptPassageDTO
    {
        public int GroupId { get; set; }
        public int GroupOrderNo { get; set; }

        public int? PassageId { get; set; }
        public int PassageNo { get; set; }

        public string Title { get; set; }
        public string PassageText { get; set; }

        public AttemptPassageDTO() { }

        public AttemptPassageDTO(DataRow row)
        {
            GroupId = Convert.ToInt32(row["GroupId"]);
            GroupOrderNo = row.Table.Columns.Contains("GroupOrderNo")
                ? Convert.ToInt32(row["GroupOrderNo"])
                : 0;

            PassageId = row.Table.Columns.Contains("PassageId") && row["PassageId"] != DBNull.Value
                ? Convert.ToInt32(row["PassageId"])
                : (int?)null;

            PassageNo = row.Table.Columns.Contains("PassageNo") && row["PassageNo"] != DBNull.Value
                ? Convert.ToInt32(row["PassageNo"])
                : 1;

            Title = row.Table.Columns.Contains("Title") && row["Title"] != DBNull.Value
                ? row["Title"].ToString()
                : null;

            PassageText = row.Table.Columns.Contains("PassageText") && row["PassageText"] != DBNull.Value
                ? row["PassageText"].ToString()
                : null;
        }
    }
}