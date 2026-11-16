using System;
using System.Data;

namespace TOEIC_Practice.DTO.LamBai
{
    public class AttemptQuestionDTO
    {
        public int AttemptQuestionId { get; set; }
        public int AttemptId { get; set; }
        public int QuestionId { get; set; }
        public int PartId { get; set; }
        public int OrderNo { get; set; }

        public string QuestionText { get; set; }
        public string Explanation { get; set; }

        public int GroupId { get; set; }
        public string GroupType { get; set; }
        public string AudioPath { get; set; }
        public string ImagePath { get; set; }
        public string PassageText { get; set; }

        public string ChosenOptionLabel { get; set; } // để load lại lựa chọn   
        public int GroupOrderNo { get; set; }        // thứ tự group trong part
        public AttemptQuestionDTO() { }

        public AttemptQuestionDTO(DataRow row)
        {
            AttemptQuestionId = (int)row["AttemptQuestionId"];
            AttemptId = (int)row["AttemptId"];
            QuestionId = (int)row["QuestionId"];
            PartId = (int)row["PartId"];
            OrderNo = (int)row["OrderNo"];

            QuestionText = row.Table.Columns.Contains("QuestionText") ? row["QuestionText"].ToString() : "";
            Explanation = row.Table.Columns.Contains("Explanation") ? row["Explanation"].ToString() : "";

            if (row.Table.Columns.Contains("GroupId")) GroupId = (int)row["GroupId"];
            GroupType = row.Table.Columns.Contains("GroupType") ? row["GroupType"].ToString() : "";
            AudioPath = row.Table.Columns.Contains("AudioPath") ? (row["AudioPath"] == DBNull.Value ? null : row["AudioPath"].ToString()) : null;
            ImagePath = row.Table.Columns.Contains("ImagePath") ? (row["ImagePath"] == DBNull.Value ? null : row["ImagePath"].ToString()) : null;
            PassageText = row.Table.Columns.Contains("PassageText") ? (row["PassageText"] == DBNull.Value ? null : row["PassageText"].ToString()) : null;

            if (row.Table.Columns.Contains("ChosenOptionLabel"))
                ChosenOptionLabel = row["ChosenOptionLabel"] == DBNull.Value ? null : row["ChosenOptionLabel"].ToString();
        }

    }
}