using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TOEIC_Practice.DAL.Helpers;
using TOEIC_Practice.DTO;
using TOEIC_Practice.DTO.Admin;

namespace TOEIC_Practice.DAL.Admin
{
    public class AdminQuestionOptionDAL
    {
        public List<AdminQuestionOptionDTO> GetByQuestion(int questionId)
        {
            DataTable dt = DataHelper.Instance.ExecuteQuerySP(
                "sp_Admin_QuestionOption_ListByQuestion",
                new SqlParameter("@QuestionId", questionId));

            List<AdminQuestionOptionDTO> list = new List<AdminQuestionOptionDTO>();
            foreach (DataRow row in dt.Rows)
                list.Add(new AdminQuestionOptionDTO(row));

            return list;
        }

        public int SaveBatch(AdminQuestionOptionBatchDTO dto)
        {
            return DataHelper.Instance.ExecuteNonQuerySP(
                "sp_Admin_QuestionOption_SaveBatch",
                new SqlParameter("@QuestionId", dto.QuestionId),
                new SqlParameter("@AnswerId_A", dto.AnswerId_A),
                new SqlParameter("@AnswerId_B", dto.AnswerId_B),
                new SqlParameter("@AnswerId_C", dto.AnswerId_C),
                new SqlParameter("@AnswerId_D", (object)dto.AnswerId_D ?? DBNull.Value));
        }

        public ValidationResultDTO ValidateByQuestion(int questionId)
        {
            DataTable dt = DataHelper.Instance.ExecuteQuerySP(
                "sp_Admin_QuestionOption_ValidateByQuestion",
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

                OptionCount = row.Table.Columns.Contains("OptionCount") && row["OptionCount"] != DBNull.Value
                    ? Convert.ToInt32(row["OptionCount"])
                    : 0,

                IsValid = row.Table.Columns.Contains("IsValid") && row["IsValid"] != DBNull.Value
                    ? Convert.ToInt32(row["IsValid"]) == 1
                    : false,

                Message = null
            };
        }
    }
}