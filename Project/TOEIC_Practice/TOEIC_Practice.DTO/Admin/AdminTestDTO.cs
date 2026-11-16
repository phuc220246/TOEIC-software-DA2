using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOEIC_Practice.DTO.Admin
{
    public class AdminTestDTO
    {
        public int TestId { get; set; }
        public int EtsId { get; set; }
        public int EtsYear { get; set; }
        public byte TestNo { get; set; }
        public string Title { get; set; }
        public bool IsActive { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public AdminTestDTO() { }

        public AdminTestDTO(DataRow row)
        {
            TestId = row.Table.Columns.Contains("TestId") ? Convert.ToInt32(row["TestId"]) : 0;
            EtsId = row.Table.Columns.Contains("EtsId") ? Convert.ToInt32(row["EtsId"]) : 0;
            EtsYear = row.Table.Columns.Contains("EtsYear") && row["EtsYear"] != DBNull.Value ? Convert.ToInt32(row["EtsYear"]) : 0;
            TestNo = row.Table.Columns.Contains("TestNo") ? Convert.ToByte(row["TestNo"]) : (byte)0;
            Title = row.Table.Columns.Contains("Title") && row["Title"] != DBNull.Value ? row["Title"].ToString() : null;
            IsActive = row.Table.Columns.Contains("IsActive") && row["IsActive"] != DBNull.Value && Convert.ToBoolean(row["IsActive"]);
            UpdatedAt = row.Table.Columns.Contains("UpdatedAt") && row["UpdatedAt"] != DBNull.Value
                ? Convert.ToDateTime(row["UpdatedAt"])
                : (DateTime?)null;
        }
    }
}
