using System;
using System.Data;

namespace TOEIC_Practice.DTO.LamBai
{
    public class AttemptOptionDTO
    {
        public int AttemptQuestionId { get; set; }      // dùng review
        public string OptionLabel { get; set; }         // A/B/C/D
        public int DisplayOrder { get; set; }           // 1..4 (SQL tinyint -> byte)
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }
        public bool IsCorrect { get; set; }             // 0/1
        public string ChosenOptionLabel { get; set; }   // dùng review

        public AttemptOptionDTO() { }

        public AttemptOptionDTO(DataRow row)
        {
            // helper nhỏ để khỏi lặp code
            object Get(string col) =>
                row.Table.Columns.Contains(col) ? row[col] : DBNull.Value;

            // AttemptQuestionId (có thể không trả về ở vài SP => default 0)
            var aq = Get("AttemptQuestionId");
            AttemptQuestionId = aq == DBNull.Value ? 0 : Convert.ToInt32(aq);

            // OptionLabel
            var ol = Get("OptionLabel");
            OptionLabel = ol == DBNull.Value ? "" : ol.ToString();

            // DisplayOrder (TINYINT => byte) -> Convert.ToInt32 để an toàn
            var d = Get("DisplayOrder");
            DisplayOrder = d == DBNull.Value ? 0 : Convert.ToInt32(d);

            // AnswerId
            var aid = Get("AnswerId");
            AnswerId = aid == DBNull.Value ? 0 : Convert.ToInt32(aid);

            // AnswerText
            var at = Get("AnswerText");
            AnswerText = at == DBNull.Value ? "" : at.ToString();

            // IsCorrect (BIT => bool hoặc byte) -> Convert.ToBoolean an toàn
            var ic = Get("IsCorrect");
            IsCorrect = ic != DBNull.Value && Convert.ToBoolean(ic);

            // ChosenOptionLabel (có trong SP review)
            var ch = Get("ChosenOptionLabel");
            ChosenOptionLabel = ch == DBNull.Value ? null : ch.ToString();
        }
    }
}