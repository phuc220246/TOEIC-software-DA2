using System;
using System.Collections.Generic;
using TOEIC_Practice.DAL;
using TOEIC_Practice.DAL.Admin;
using TOEIC_Practice.DTO;
using TOEIC_Practice.DTO.Admin;

namespace TOEIC_Practice.BLL.Admin
{
    public class AdminAnswerBLL
    {
        private readonly AdminAnswerDAL _dal = new AdminAnswerDAL();

        public List<AdminAnswerDTO> GetByQuestion(int questionId)
        {
            if (questionId <= 0) throw new Exception("QuestionId không hợp lệ.");
            return _dal.GetByQuestion(questionId);
        }

        public AdminAnswerDTO GetById(int answerId)
        {
            if (answerId <= 0) throw new Exception("AnswerId không hợp lệ.");
            return _dal.GetById(answerId);
        }

        public int Create(AdminAnswerDTO dto)
        {
            ValidateForCreate(dto);
            dto.AnswerText = Normalize(dto.AnswerText);
            return _dal.Create(dto);
        }

        public void Update(AdminAnswerDTO dto)
        {
            ValidateForUpdate(dto);
            dto.AnswerText = Normalize(dto.AnswerText);
            _dal.Update(dto);
        }

        public void Deactivate(int answerId)
        {
            if (answerId <= 0) throw new Exception("AnswerId không hợp lệ.");
            _dal.Deactivate(answerId);
        }

        public ValidationResultDTO ValidateByQuestion(int questionId)
        {
            if (questionId <= 0) throw new Exception("QuestionId không hợp lệ.");

            ValidationResultDTO result = _dal.ValidateByQuestion(questionId);
            if (result == null) return null;

            if (result.IsValid)
            {
                result.Message = "Danh sách Answer hợp lệ.";
            }
            else
            {
                if (result.PartId == 2)
                {
                    result.Message = string.Format(
                        "Part 2 phải có đúng 3 answer active và đúng 1 đáp án đúng. Hiện tại: Active={0}, Correct={1}.",
                        result.ActiveAnswerCount,
                        result.CorrectCount);
                }
                else
                {
                    result.Message = string.Format(
                        "Part này phải có đúng 4 answer active và đúng 1 đáp án đúng. Hiện tại: Active={0}, Correct={1}.",
                        result.ActiveAnswerCount,
                        result.CorrectCount);
                }
            }

            return result;
        }

        private void ValidateForCreate(AdminAnswerDTO dto)
        {
            if (dto == null) throw new Exception("Dữ liệu Answer không hợp lệ.");
            if (dto.QuestionId <= 0) throw new Exception("Phải chọn Question.");
            if (string.IsNullOrWhiteSpace(dto.AnswerText))
                throw new Exception("AnswerText không được để trống.");
        }

        private void ValidateForUpdate(AdminAnswerDTO dto)
        {
            if (dto == null) throw new Exception("Dữ liệu Answer không hợp lệ.");
            if (dto.AnswerId <= 0) throw new Exception("AnswerId không hợp lệ.");
            if (string.IsNullOrWhiteSpace(dto.AnswerText))
                throw new Exception("AnswerText không được để trống.");
        }

        private string Normalize(string value)
        {
            return string.IsNullOrWhiteSpace(value) ? null : value.Trim();
        }
    }
}