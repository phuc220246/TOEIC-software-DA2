using System;
using System.Data;

namespace TOEIC_Practice.DTO.LamBai
{
    public class AttemptReviewQuestionDTO
    {
        public int AttemptQuestionId { get; set; }
        public int AttemptId { get; set; }
        public int QuestionId { get; set; }
        public int PartId { get; set; }
        public int OrderNo { get; set; }

        public int GroupId { get; set; }              // quan trọng cho Part 6/7
        public string GroupType { get; set; }         // SINGLE / PASSAGE / ...
        public string PassageText { get; set; }       // Part 6/7
        public string AudioPath { get; set; }
        public string ImagePath { get; set; }

        public string QuestionText { get; set; }
        public string Explanation { get; set; }

        public string ChosenOptionLabel { get; set; }   // A/B/C/D hoặc null
        public string CorrectOptionLabel { get; set; }  // A/B/C/D

        public AttemptReviewQuestionDTO() { }

        public AttemptReviewQuestionDTO(DataRow row)
        {
            AttemptQuestionId = row.Table.Columns.Contains("AttemptQuestionId") ? Convert.ToInt32(row["AttemptQuestionId"]) : 0;
            AttemptId = row.Table.Columns.Contains("AttemptId") ? Convert.ToInt32(row["AttemptId"]) : 0;
            QuestionId = row.Table.Columns.Contains("QuestionId") ? Convert.ToInt32(row["QuestionId"]) : 0;
            PartId = row.Table.Columns.Contains("PartId") ? Convert.ToInt32(row["PartId"]) : 0;
            OrderNo = row.Table.Columns.Contains("OrderNo") ? Convert.ToInt32(row["OrderNo"]) : 0;

            GroupId = row.Table.Columns.Contains("GroupId") ? Convert.ToInt32(row["GroupId"]) : 0;
            GroupType = row.Table.Columns.Contains("GroupType") ? (row["GroupType"] == DBNull.Value ? "" : row["GroupType"].ToString()) : "";

            PassageText = row.Table.Columns.Contains("PassageText") ? (row["PassageText"] == DBNull.Value ? "" : row["PassageText"].ToString()) : "";
            AudioPath = row.Table.Columns.Contains("AudioPath") ? (row["AudioPath"] == DBNull.Value ? "" : row["AudioPath"].ToString()) : "";
            ImagePath = row.Table.Columns.Contains("ImagePath") ? (row["ImagePath"] == DBNull.Value ? "" : row["ImagePath"].ToString()) : "";

            QuestionText = row.Table.Columns.Contains("QuestionText") ? (row["QuestionText"] == DBNull.Value ? "" : row["QuestionText"].ToString()) : "";
            Explanation = row.Table.Columns.Contains("Explanation") ? (row["Explanation"] == DBNull.Value ? "" : row["Explanation"].ToString()) : "";

            ChosenOptionLabel = row.Table.Columns.Contains("ChosenOptionLabel") ? (row["ChosenOptionLabel"] == DBNull.Value ? "" : row["ChosenOptionLabel"].ToString()) : "";
            CorrectOptionLabel = row.Table.Columns.Contains("CorrectOptionLabel") ? (row["CorrectOptionLabel"] == DBNull.Value ? "" : row["CorrectOptionLabel"].ToString()) : "";
        }
    }
}