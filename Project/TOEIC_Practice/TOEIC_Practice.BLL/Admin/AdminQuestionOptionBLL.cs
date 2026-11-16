using System;
using System.Collections.Generic;
using System.Linq;
using TOEIC_Practice.DAL;
using TOEIC_Practice.DAL.Admin;
using TOEIC_Practice.DTO;
using TOEIC_Practice.DTO.Admin;

namespace TOEIC_Practice.BLL.Admin
{
    public class AdminQuestionOptionBLL
    {
        private readonly AdminQuestionOptionDAL _dal = new AdminQuestionOptionDAL();
        private readonly AdminQuestionDAL _questionDal = new AdminQuestionDAL();
        private readonly AdminAnswerDAL _answerDal = new AdminAnswerDAL();

        public List<AdminQuestionOptionDTO> GetByQuestion(int questionId)
        {
            if (questionId <= 0) throw new Exception("QuestionId không hợp lệ.");
            return _dal.GetByQuestion(questionId);
        }

        public ValidationResultDTO ValidateByQuestion(int questionId)
        {
            if (questionId <= 0) throw new Exception("QuestionId không hợp lệ.");

            ValidationResultDTO result = _dal.ValidateByQuestion(questionId);
            if (result == null) return null;

            if (result.IsValid)
            {
                result.Message = "Danh sách QuestionOption hợp lệ.";
            }
            else
            {
                if (result.PartId == 2)
                    result.Message = string.Format("Part 2 phải có đúng 3 option. Hiện tại: {0}.", result.OptionCount);
                else
                    result.Message = string.Format("Part này phải có đúng 4 option. Hiện tại: {0}.", result.OptionCount);
            }

            return result;
        }

        public void SaveBatch(AdminQuestionOptionBatchDTO dto)
        {
            if (dto == null) throw new Exception("Dữ liệu QuestionOption batch không hợp lệ.");
            if (dto.QuestionId <= 0) throw new Exception("QuestionId không hợp lệ.");
            if (dto.AnswerId_A <= 0 || dto.AnswerId_B <= 0 || dto.AnswerId_C <= 0)
                throw new Exception("Phải chọn đủ Answer cho A, B, C.");

            AdminQuestionDTO question = _questionDal.GetById(dto.QuestionId);
            if (question == null)
                throw new Exception("Question không tồn tại.");

            List<int> answerIds = new List<int>
            {
                dto.AnswerId_A,
                dto.AnswerId_B,
                dto.AnswerId_C
            };

            if (dto.AnswerId_D.HasValue)
                answerIds.Add(dto.AnswerId_D.Value);

            if (answerIds.Distinct().Count() != answerIds.Count)
                throw new Exception("Các Answer dùng cho option không được trùng nhau.");

            List<AdminAnswerDTO> answers = _answerDal.GetByQuestion(dto.QuestionId);

            bool hasA = answers.Any(x => x.AnswerId == dto.AnswerId_A);
            bool hasB = answers.Any(x => x.AnswerId == dto.AnswerId_B);
            bool hasC = answers.Any(x => x.AnswerId == dto.AnswerId_C);
            bool hasD = !dto.AnswerId_D.HasValue || answers.Any(x => x.AnswerId == dto.AnswerId_D.Value);

            if (!hasA) throw new Exception("Answer A không thuộc Question này.");
            if (!hasB) throw new Exception("Answer B không thuộc Question này.");
            if (!hasC) throw new Exception("Answer C không thuộc Question này.");
            if (!hasD) throw new Exception("Answer D không thuộc Question này.");

            if (question.PartId == 2)
            {
                if (dto.AnswerId_D.HasValue)
                    throw new Exception("Part 2 chỉ được có option A, B, C.");
            }
            else
            {
                if (!dto.AnswerId_D.HasValue || dto.AnswerId_D.Value <= 0)
                    throw new Exception("Part này phải có đủ option A, B, C, D.");
            }

            _dal.SaveBatch(dto);
        }
    }
}