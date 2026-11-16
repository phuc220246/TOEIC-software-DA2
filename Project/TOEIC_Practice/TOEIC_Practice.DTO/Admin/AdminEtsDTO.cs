using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOEIC_Practice.DTO.Admin
{
    public class AdminEtsDTO
    {
        public int EtsId { get; set; }
        public int Year { get; set; }
        public string Title { get; set; }
        public bool IsActive { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public AdminEtsDTO() { }

        public AdminEtsDTO(DataRow row)
        {
            EtsId = row.Table.Columns.Contains("EtsId") ? Convert.ToInt32(row["EtsId"]) : 0;
            Year = row.Table.Columns.Contains("Year") ? Convert.ToInt32(row["Year"]) : 0;
            Title = row.Table.Columns.Contains("Title") && row["Title"] != DBNull.Value ? row["Title"].ToString() : null;
            IsActive = row.Table.Columns.Contains("IsActive") && row["IsActive"] != DBNull.Value && Convert.ToBoolean(row["IsActive"]);
            UpdatedAt = row.Table.Columns.Contains("UpdatedAt") && row["UpdatedAt"] != DBNull.Value
                ? Convert.ToDateTime(row["UpdatedAt"])
                : (DateTime?)null;
        }
    }
}
