using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TOEIC_Practice.DAL.Helpers;
using TOEIC_Practice.DTO;
using TOEIC_Practice.DTO.Admin;

namespace TOEIC_Practice.DAL.Admin
{
    public class AdminAnswerDAL
    {
        public List<AdminAnswerDTO> GetByQuestion(int questionId)
        {
            DataTable dt = DataHelper.Instance.ExecuteQuerySP(
                "sp_Admin_Answer_ListByQuestion",
                new SqlParameter("@QuestionId", questionId));

            List<AdminAnswerDTO> list = new List<AdminAnswerDTO>();
            foreach (DataRow row in dt.Rows)
                list.Add(new AdminAnswerDTO(row));

            return list;
        }

        public AdminAnswerDTO GetById(int answerId)
        {
            DataTable dt = DataHelper.Instance.ExecuteQuerySP(
                "sp_Admin_Answer_GetById",
                new SqlParameter("@AnswerId", answerId));

            if (dt.Rows.Count == 0) return null;
            return new AdminAnswerDTO(dt.Rows[0]);
        }

        public int Create(AdminAnswerDTO dto)
        {
            object result = DataHelper.Instance.ExecuteScalarSP(
                "sp_Admin_Answer_Create",
                new SqlParameter("@QuestionId", dto.QuestionId),
                new SqlParameter("@AnswerText", dto.AnswerText),
                new SqlParameter("@IsCorrect", dto.IsCorrect));

            return Convert.ToInt32(result);
        }

        public int Update(AdminAnswerDTO dto)
        {
            return DataHelper.Instance.ExecuteNonQuerySP(
                "sp_Admin_Answer_Update",
                new SqlParameter("@AnswerId", dto.AnswerId),
                new SqlParameter("@AnswerText", dto.AnswerText),
                new SqlParameter("@IsCorrect", dto.IsCorrect),
                new SqlParameter("@IsActive", dto.IsActive));
        }

        public int Deactivate(int answerId)
        {
            return DataHelper.Instance.ExecuteNonQuerySP(
                "sp_Admin_Answer_Deactivate",
                new SqlParameter("@AnswerId", answerId));
        }

        public ValidationResultDTO ValidateByQuestion(int questionId)
        {
            DataTable dt = DataHelper.Instance.ExecuteQuerySP(
                "sp_Admin_Answer_ValidateByQuestion",
                new SqlParameter("@QuestionId", questionId));

            if (dt.Rows.Count == 0) return null;

            DataRow row = dt.Rows[0];

            return new ValidationResultDTO
            {
                QuestionId = row.Table.Columns.Contains("QuestionId") && row["QuestionId"] != DBNull.Value
                    ? Convert.ToInt32(row["QuestionId"])
                    : 0,

                PartId = row.Table.Columns.Contains("PartId") && row["PartId"] != DBNull.Value
                    ? Convert.ToInt32(row["PartId"])
                    : 0,

                ActiveAnswerCount = row.Table.Columns.Contains("ActiveAnswerCount") && row["ActiveAnswerCount"] != DBNull.Value
                    ? Convert.ToInt32(row["ActiveAnswerCount"])
                    : 0,

                CorrectCount = row.Table.Columns.Contains("CorrectCount") && row["CorrectCount"] != DBNull.Value
                    ? Convert.ToInt32(row["CorrectCount"])
                    : 0,

                IsValid = row.Table.Columns.Contains("IsValid") && row["IsValid"] != DBNull.Value
                    ? Convert.ToInt32(row["IsValid"]) == 1
                    : false,

                Message = null
            };
        }
    }
}