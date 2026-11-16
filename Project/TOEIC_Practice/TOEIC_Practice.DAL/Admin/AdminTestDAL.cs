using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TOEIC_Practice.DAL.Helpers;
using TOEIC_Practice.DTO;
using TOEIC_Practice.DTO.Admin;

namespace TOEIC_Practice.DAL.Admin
{
    public class AdminTestDAL
    {
        public List<AdminTestDTO> GetAll()
        {
            DataTable dt = DataHelper.Instance.ExecuteQuerySP("sp_Admin_Test_List");
            List<AdminTestDTO> list = new List<AdminTestDTO>();

            foreach (DataRow row in dt.Rows)
                list.Add(new AdminTestDTO(row));

            return list;
        }

        public List<AdminTestDTO> GetByEts(int etsId)
        {
            DataTable dt = DataHelper.Instance.ExecuteQuerySP(
                "sp_Admin_Test_ListByEts",
                new SqlParameter("@EtsId", etsId));

            List<AdminTestDTO> list = new List<AdminTestDTO>();
            foreach (DataRow row in dt.Rows)
                list.Add(new AdminTestDTO(row));

            return list;
        }

        public AdminTestDTO GetById(int testId)
        {
            DataTable dt = DataHelper.Instance.ExecuteQuerySP(
                "sp_Admin_Test_GetById",
                new SqlParameter("@TestId", testId));

            if (dt.Rows.Count == 0) return null;
            return new AdminTestDTO(dt.Rows[0]);
        }

        public int Create(AdminTestDTO dto)
        {
            object result = DataHelper.Instance.ExecuteScalarSP(
                "sp_Admin_Test_Create",
                new SqlParameter("@EtsId", dto.EtsId),
                new SqlParameter("@TestNo", dto.TestNo),
                new SqlParameter("@Title", (object)dto.Title ?? DBNull.Value));

            return Convert.ToInt32(result);
        }

        public int Update(AdminTestDTO dto)
        {
            return DataHelper.Instance.ExecuteNonQuerySP(
                "sp_Admin_Test_Update",
                new SqlParameter("@TestId", dto.TestId),
                new SqlParameter("@Title", (object)dto.Title ?? DBNull.Value),
                new SqlParameter("@IsActive", dto.IsActive));
        }

        public int Deactivate(int testId)
        {
            return DataHelper.Instance.ExecuteNonQuerySP(
                "sp_Admin_Test_Deactivate",
                new SqlParameter("@TestId", testId));
        }
    }
}