using System;
using System.Collections.Generic;
using TOEIC_Practice.DAL.LamBai;
using TOEIC_Practice.DTO.LamBai;

namespace TOEIC_Practice.BLL.LamBai
{
    public class AttemptOptionBLL
    {
        private readonly AttemptOptionDAL _dal = new AttemptOptionDAL();

        public List<AttemptOptionDTO> GetOptions(int attemptQuestionId)
        {
            if (attemptQuestionId <= 0) throw new ArgumentException("AttemptQuestionId không hợp lệ.");
            return _dal.GetOptions(attemptQuestionId);
        }

        public void SaveAnswer(int attemptQuestionId, string optionLabel)
        {
            if (attemptQuestionId <= 0) throw new ArgumentException("AttemptQuestionId không hợp lệ.");
            if (string.IsNullOrWhiteSpace(optionLabel)) throw new ArgumentException("Chưa chọn đáp án.");

            _dal.SaveAnswer(attemptQuestionId, optionLabel.Trim().ToUpper());
        }
    }
}