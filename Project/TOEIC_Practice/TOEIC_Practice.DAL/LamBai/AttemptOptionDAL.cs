using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TOEIC_Practice.DAL.Helpers;
using TOEIC_Practice.DTO.LamBai;

namespace TOEIC_Practice.DAL.LamBai
{
    public class AttemptOptionDAL
    {
        public List<AttemptOptionDTO> GetOptions(int attemptQuestionId)
        {
            DataTable dt = DataHelper.Instance.ExecuteQuerySP(
                "sp_Attempt_GetOptions",
                new SqlParameter("@AttemptQuestionId", attemptQuestionId)
            );

            var list = new List<AttemptOptionDTO>();
            foreach (DataRow row in dt.Rows)
                list.Add(new AttemptOptionDTO(row));

            return list;
        }

        public void SaveAnswer(int attemptQuestionId, string chosenOptionLabel)
        {
            DataHelper.Instance.ExecuteNonQuerySP(
                "sp_Attempt_SaveAnswer",
                new SqlParameter("@AttemptQuestionId", attemptQuestionId),
                new SqlParameter("@ChosenOptionLabel", chosenOptionLabel)
            );
        }
    }
}