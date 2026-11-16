using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TOEIC_Practice.DAL.Helpers;
using TOEIC_Practice.DTO.Admin;

namespace TOEIC_Practice.DAL.Admin
{
    public class AdminAccountDAL
    {
        public List<AdminAccountDTO> ListAll()
        {
            DataTable dt = DataHelper.Instance.ExecuteQuerySP("sp_Admin_Account_List");
            List<AdminAccountDTO> list = new List<AdminAccountDTO>();

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new AdminAccountDTO(row));
            }

            return list;
        }

        public List<AdminAccountDTO> Search(string keyword)
        {
            DataTable dt = DataHelper.Instance.ExecuteQuerySP(
                "sp_Admin_Account_Search",
                new SqlParameter("@Keyword", SqlDbType.NVarChar, 100)
                {
                    Value = (object)keyword ?? DBNull.Value
                });

            List<AdminAccountDTO> list = new List<AdminAccountDTO>();

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new AdminAccountDTO(row));
            }

            return list;
        }

        public AdminAccountDTO GetById(int accountId)
        {
            DataTable dt = DataHelper.Instance.ExecuteQuerySP(
                "sp_Admin_Account_GetById",
                new SqlParameter("@AccountId", SqlDbType.Int) { Value = accountId });

            if (dt.Rows.Count <= 0)
                return null;

            return new AdminAccountDTO(dt.Rows[0]);
        }

        public List<AdminRoleDTO> ListRoles()
        {
            DataTable dt = DataHelper.Instance.ExecuteQuerySP("sp_Admin_Role_List");
            List<AdminRoleDTO> list = new List<AdminRoleDTO>();

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new AdminRoleDTO(row));
            }

            return list;
        }

        public int Create(string username, string displayName, byte[] passwordHash, byte[] passwordSalt, string roleName, bool isActive)
        {
            object result = DataHelper.Instance.ExecuteScalarSP(
                "sp_Admin_Account_Create",
                new SqlParameter("@Username", SqlDbType.NVarChar, 50) { Value = username },
                new SqlParameter("@DisplayName", SqlDbType.NVarChar, 100) { Value = (object)displayName ?? DBNull.Value },
                new SqlParameter("@PasswordHash", SqlDbType.VarBinary, 64) { Value = passwordHash },
                new SqlParameter("@PasswordSalt", SqlDbType.VarBinary, 32) { Value = passwordSalt },
                new SqlParameter("@RoleName", SqlDbType.VarChar, 30) { Value = roleName },
                new SqlParameter("@IsActive", SqlDbType.Bit) { Value = isActive }
            );

            return Convert.ToInt32(result);
        }

        public void Update(int accountId, string displayName, string roleName, bool isActive)
        {
            DataHelper.Instance.ExecuteNonQuerySP(
                "sp_Admin_Account_Update",
                new SqlParameter("@AccountId", SqlDbType.Int) { Value = accountId },
                new SqlParameter("@DisplayName", SqlDbType.NVarChar, 100) { Value = (object)displayName ?? DBNull.Value },
                new SqlParameter("@RoleName", SqlDbType.VarChar, 30) { Value = roleName },
                new SqlParameter("@IsActive", SqlDbType.Bit) { Value = isActive }
            );
        }

        public void SetActive(int accountId, bool isActive)
        {
            DataHelper.Instance.ExecuteNonQuerySP(
                "sp_Admin_Account_SetActive",
                new SqlParameter("@AccountId", SqlDbType.Int) { Value = accountId },
                new SqlParameter("@IsActive", SqlDbType.Bit) { Value = isActive }
            );
        }

        public void ResetPassword(int accountId, byte[] passwordHash, byte[] passwordSalt)
        {
            DataHelper.Instance.ExecuteNonQuerySP(
                "sp_Admin_Account_ResetPassword",
                new SqlParameter("@AccountId", SqlDbType.Int) { Value = accountId },
                new SqlParameter("@PasswordHash", SqlDbType.VarBinary, 64) { Value = passwordHash },
                new SqlParameter("@PasswordSalt", SqlDbType.VarBinary, 32) { Value = passwordSalt }
            );
        }
    }
}