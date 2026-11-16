using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TOEIC_Practice.DAL.Helpers;
using TOEIC_Practice.DTO;
using TOEIC_Practice.DTO.Admin;

namespace TOEIC_Practice.DAL.Admin
{
    public class AdminGroupDAL
    {
        public List<AdminQuestionGroupDTO> GetByTest(int testId)
        {
            DataTable dt = DataHelper.Instance.ExecuteQuerySP(
                "sp_Admin_Group_ListByTest",
                new SqlParameter("@TestId", testId));

            List<AdminQuestionGroupDTO> list = new List<AdminQuestionGroupDTO>();
            foreach (DataRow row in dt.Rows)
                list.Add(new AdminQuestionGroupDTO(row));

            return list;
        }

        public List<AdminQuestionGroupDTO> GetByTestPart(int testId, int partId)
        {
            DataTable dt = DataHelper.Instance.ExecuteQuerySP(
                "sp_Admin_Group_ListByTestPart",
                new SqlParameter("@TestId", testId),
                new SqlParameter("@PartId", partId));

            List<AdminQuestionGroupDTO> list = new List<AdminQuestionGroupDTO>();
            foreach (DataRow row in dt.Rows)
                list.Add(new AdminQuestionGroupDTO(row));

            return list;
        }

        public AdminQuestionGroupDTO GetById(int groupId)
        {
            DataTable dt = DataHelper.Instance.ExecuteQuerySP(
                "sp_Admin_Group_GetById",
                new SqlParameter("@GroupId", groupId));

            if (dt.Rows.Count == 0) return null;
            return new AdminQuestionGroupDTO(dt.Rows[0]);
        }

        public int Create(AdminQuestionGroupDTO dto)
        {
            object result = DataHelper.Instance.ExecuteScalarSP(
                "sp_Admin_Group_Create",
                new SqlParameter("@TestId", dto.TestId),
                new SqlParameter("@PartId", dto.PartId),
                new SqlParameter("@GroupType", dto.GroupType),
                new SqlParameter("@AudioPath", (object)dto.AudioPath ?? DBNull.Value),
                new SqlParameter("@ImagePath", (object)dto.ImagePath ?? DBNull.Value),
                new SqlParameter("@PassageText", (object)dto.PassageText ?? DBNull.Value),
                new SqlParameter("@OrderNo", dto.OrderNo));

            return Convert.ToInt32(result);
        }

        public int Update(AdminQuestionGroupDTO dto)
        {
            return DataHelper.Instance.ExecuteNonQuerySP(
                "sp_Admin_Group_Update",
                new SqlParameter("@GroupId", dto.GroupId),
                new SqlParameter("@GroupType", dto.GroupType),
                new SqlParameter("@AudioPath", (object)dto.AudioPath ?? DBNull.Value),
                new SqlParameter("@ImagePath", (object)dto.ImagePath ?? DBNull.Value),
                new SqlParameter("@PassageText", (object)dto.PassageText ?? DBNull.Value),
                new SqlParameter("@OrderNo", dto.OrderNo),
                new SqlParameter("@IsActive", dto.IsActive));
        }

        public int Deactivate(int groupId)
        {
            return DataHelper.Instance.ExecuteNonQuerySP(
                "sp_Admin_Group_Deactivate",
                new SqlParameter("@GroupId", groupId));
        }
    }
}