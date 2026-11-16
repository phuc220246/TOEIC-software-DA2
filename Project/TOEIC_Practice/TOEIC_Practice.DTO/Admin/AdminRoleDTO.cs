using System;
using System.Data;

namespace TOEIC_Practice.DTO.Admin
{
    public class AdminRoleDTO
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public AdminRoleDTO()
        {
        }

        public AdminRoleDTO(DataRow row)
        {
            if (row.Table.Columns.Contains("RoleId") && row["RoleId"] != DBNull.Value)
                RoleId = Convert.ToInt32(row["RoleId"]);

            if (row.Table.Columns.Contains("RoleName") && row["RoleName"] != DBNull.Value)
                RoleName = row["RoleName"].ToString();
        }
    }
}