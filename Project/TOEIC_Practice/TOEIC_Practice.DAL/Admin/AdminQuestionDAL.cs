using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TOEIC_Practice.DAL.Helpers;
using TOEIC_Practice.DTO;
using TOEIC_Practice.DTO.Admin;

namespace TOEIC_Practice.DAL.Admin
{
    public class AdminQuestionDAL
    {
        public List<AdminQuestionDTO> GetByGroup(int groupId)
        {
            DataTable dt = DataHelper.Instance.ExecuteQuerySP(
                "sp_Admin_Question_ListByGroup",
                new SqlParameter("@GroupId", groupId));

            List<AdminQuestionDTO> list = new List<AdminQuestionDTO>();
            foreach (DataRow row in dt.Rows)
                list.Add(new AdminQuestionDTO(row));

            return list;
        }

        public AdminQuestionDTO GetById(int questionId)
        {
            DataTable dt = DataHelper.Instance.ExecuteQuerySP(
                "sp_Admin_Question_GetById",
                new SqlParameter("@QuestionId", questionId));

            if (dt.Rows.Count == 0) return null;
            return new AdminQuestionDTO(dt.Rows[0]);
        }

        public int Create(AdminQuestionDTO dto)
        {
            object result = DataHelper.Instance.ExecuteScalarSP(
                "sp_Admin_Question_Create",
                new SqlParameter("@GroupId", dto.GroupId),
                new SqlParameter("@QuestionText", (object)dto.QuestionText ?? DBNull.Value),
                new SqlParameter("@Explanation", (object)dto.Explanation ?? DBNull.Value),
                new SqlParameter("@OrderInGroup", dto.OrderInGroup));

            return Convert.ToInt32(result);
        }

        public int Update(AdminQuestionDTO dto)
        {
            return DataHelper.Instance.ExecuteNonQuerySP(
                "sp_Admin_Question_Update",
                new SqlParameter("@QuestionId", dto.QuestionId),
                new SqlParameter("@QuestionText", (object)dto.QuestionText ?? DBNull.Value),
                new SqlParameter("@Explanation", (object)dto.Explanation ?? DBNull.Value),
                new SqlParameter("@OrderInGroup", dto.OrderInGroup),
                new SqlParameter("@IsActive", dto.IsActive));
        }

        public int Deactivate(int questionId)
        {
            return DataHelper.Instance.ExecuteNonQuerySP(
                "sp_Admin_Question_Deactivate",
                new SqlParameter("@QuestionId", questionId));
        }
    }
}