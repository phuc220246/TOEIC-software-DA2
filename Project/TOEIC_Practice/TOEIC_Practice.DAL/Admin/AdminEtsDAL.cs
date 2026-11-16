using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TOEIC_Practice.DAL.Helpers;
using TOEIC_Practice.DTO;
using TOEIC_Practice.DTO.Admin;

namespace TOEIC_Practice.DAL.Admin
{
    public class AdminEtsDAL
    {
        public List<AdminEtsDTO> GetAll()
        {
            DataTable dt = DataHelper.Instance.ExecuteQuerySP("sp_Admin_Ets_List");
            List<AdminEtsDTO> list = new List<AdminEtsDTO>();

            foreach (DataRow row in dt.Rows)
                list.Add(new AdminEtsDTO(row));

            return list;
        }

        public AdminEtsDTO GetById(int etsId)
        {
            DataTable dt = DataHelper.Instance.ExecuteQuerySP(
                "sp_Admin_Ets_GetById",
                new SqlParameter("@EtsId", etsId));

            if (dt.Rows.Count == 0) return null;
            return new AdminEtsDTO(dt.Rows[0]);
        }

        public int Create(AdminEtsDTO dto)
        {
            object result = DataHelper.Instance.ExecuteScalarSP(
                "sp_Admin_Ets_Create",
                new SqlParameter("@Year", dto.Year),
                new SqlParameter("@Title", (object)dto.Title ?? DBNull.Value));

            return Convert.ToInt32(result);
        }

        public int Update(AdminEtsDTO dto)
        {
            return DataHelper.Instance.ExecuteNonQuerySP(
                "sp_Admin_Ets_Update",
                new SqlParameter("@EtsId", dto.EtsId),
                new SqlParameter("@Year", dto.Year),
                new SqlParameter("@Title", (object)dto.Title ?? DBNull.Value),
                new SqlParameter("@IsActive", dto.IsActive));
        }

        public int Deactivate(int etsId)
        {
            return DataHelper.Instance.ExecuteNonQuerySP(
                "sp_Admin_Ets_Deactivate",
                new SqlParameter("@EtsId", etsId));
        }
    }
}