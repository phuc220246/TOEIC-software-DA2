using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TOEIC_Practice.DAL.Helpers;
using TOEIC_Practice.DTO.TaiKhoan;

namespace TOEIC_Practice.DAL.TaiKhoan
{
    public class AccountDAL
    {
        public AccountDTO GetByUsername(string username)
        {
            DataTable dt = DataHelper.Instance.ExecuteQuerySP(
                "sp_Account_GetByUsername",
                new SqlParameter("@Username", SqlDbType.NVarChar, 50) { Value = username }
            );

            if (dt.Rows.Count == 0) return null;
            return new AccountDTO(dt.Rows[0]);
        }

        public List<string> GetRoles(int accountId)
        {
            DataTable dt = DataHelper.Instance.ExecuteQuerySP(
                "sp_Account_GetRoles",
                new SqlParameter("@AccountId", SqlDbType.Int) { Value = accountId }
            );

            List<string> roles = new List<string>();
            foreach (DataRow row in dt.Rows)
                roles.Add(row["RoleName"].ToString());

            return roles;
        }

        public void UpdateLastLogin(int accountId)
        {
            DataHelper.Instance.ExecuteNonQuerySP(
                "sp_Account_UpdateLastLogin",
                new SqlParameter("@AccountId", SqlDbType.Int) { Value = accountId }
            );
        }

        public int CreateAccount(string username, string displayName, byte[] hash, byte[] salt, bool isActive = true)
        {
            object idObj = DataHelper.Instance.ExecuteScalarSP(
                "sp_Account_Create",
                new SqlParameter("@Username", SqlDbType.NVarChar, 50) { Value = username },
                new SqlParameter("@DisplayName", SqlDbType.NVarChar, 100) { Value = displayName },
                new SqlParameter("@PasswordHash", SqlDbType.VarBinary, 64) { Value = hash },
                new SqlParameter("@PasswordSalt", SqlDbType.VarBinary, 32) { Value = salt },
                new SqlParameter("@IsActive", SqlDbType.Bit) { Value = isActive }
            );

            return System.Convert.ToInt32(idObj);
        }

        public void AssignRole(int accountId, string roleName)
        {
            DataHelper.Instance.ExecuteNonQuerySP(
                "sp_Account_AssignRole",
                new SqlParameter("@AccountId", SqlDbType.Int) { Value = accountId },
                new SqlParameter("@RoleName", SqlDbType.NVarChar, 50) { Value = roleName }
            );
        }
    }
}