using System;
using System.Data;

namespace TOEIC_Practice.DTO.TaiKhoan
{
    public class AccountDTO
    {
        public int AccountId { get; set; }
        public string Username { get; set; }
        public string DisplayName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastLoginAt { get; set; }

        public AccountDTO() { }

        public AccountDTO(DataRow row)
        {
            AccountId = Convert.ToInt32(row["AccountId"]);
            Username = row["Username"].ToString();
            DisplayName = row["DisplayName"] == DBNull.Value ? null : row["DisplayName"].ToString();
            PasswordHash = (byte[])row["PasswordHash"];
            PasswordSalt = (byte[])row["PasswordSalt"];
            IsActive = Convert.ToBoolean(row["IsActive"]);
            CreatedAt = Convert.ToDateTime(row["CreatedAt"]);
            LastLoginAt = row["LastLoginAt"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["LastLoginAt"]);
        }
    }
}