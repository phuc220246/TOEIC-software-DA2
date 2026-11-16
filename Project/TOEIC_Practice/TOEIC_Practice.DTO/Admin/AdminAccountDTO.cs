using System;
using System.Data;

namespace TOEIC_Practice.DTO.Admin
{
    public class AdminAccountDTO
    {
        public int AccountId { get; set; }
        public string Username { get; set; }
        public string DisplayName { get; set; }
        public string RoleName { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastLoginAt { get; set; }

        public AdminAccountDTO()
        {
        }

        public AdminAccountDTO(DataRow row)
        {
            if (row.Table.Columns.Contains("AccountId") && row["AccountId"] != DBNull.Value)
                AccountId = Convert.ToInt32(row["AccountId"]);

            if (row.Table.Columns.Contains("Username") && row["Username"] != DBNull.Value)
                Username = row["Username"].ToString();

            if (row.Table.Columns.Contains("DisplayName") && row["DisplayName"] != DBNull.Value)
                DisplayName = row["DisplayName"].ToString();

            if (row.Table.Columns.Contains("RoleName") && row["RoleName"] != DBNull.Value)
                RoleName = row["RoleName"].ToString();

            if (row.Table.Columns.Contains("IsActive") && row["IsActive"] != DBNull.Value)
                IsActive = Convert.ToBoolean(row["IsActive"]);

            if (row.Table.Columns.Contains("CreatedAt") && row["CreatedAt"] != DBNull.Value)
                CreatedAt = Convert.ToDateTime(row["CreatedAt"]);

            if (row.Table.Columns.Contains("LastLoginAt") && row["LastLoginAt"] != DBNull.Value)
                LastLoginAt = Convert.ToDateTime(row["LastLoginAt"]);
        }
    }
}