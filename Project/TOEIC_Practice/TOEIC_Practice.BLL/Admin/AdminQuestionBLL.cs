using System;
using System.Collections.Generic;
using TOEIC_Practice.DAL;
using TOEIC_Practice.DAL.Admin;
using TOEIC_Practice.DTO;
using TOEIC_Practice.DTO.Admin;

namespace TOEIC_Practice.BLL.Admin
{
    public class AdminQuestionBLL
    {
        private readonly AdminQuestionDAL _dal = new AdminQuestionDAL();

        public List<AdminQuestionDTO> GetByGroup(int groupId)
        {
            if (groupId <= 0) throw new Exception("GroupId không hợp lệ.");
            return _dal.GetByGroup(groupId);
        }

        public AdminQuestionDTO GetById(int questionId)
        {
            if (questionId <= 0) throw new Exception("QuestionId không hợp lệ.");
            return _dal.GetById(questionId);
        }

        public int Create(AdminQuestionDTO dto)
        {
            ValidateForCreate(dto);
            Normalize(dto);
            return _dal.Create(dto);
        }

        public void Update(AdminQuestionDTO dto)
        {
            ValidateForUpdate(dto);
            Normalize(dto);
            _dal.Update(dto);
        }

        public void Deactivate(int questionId)
        {
            if (questionId <= 0) throw new Exception("QuestionId không hợp lệ.");
            _dal.Deactivate(questionId);
        }

        private void ValidateForCreate(AdminQuestionDTO dto)
        {
            if (dto == null) throw new Exception("Dữ liệu Question không hợp lệ.");
            if (dto.GroupId <= 0) throw new Exception("Phải chọn Group.");
            if (dto.OrderInGroup <= 0) throw new Exception("OrderInGroup phải lớn hơn 0.");
        }

        private void ValidateForUpdate(AdminQuestionDTO dto)
        {
            if (dto == null) throw new Exception("Dữ liệu Question không hợp lệ.");
            if (dto.QuestionId <= 0) throw new Exception("QuestionId không hợp lệ.");
            if (dto.OrderInGroup <= 0) throw new Exception("OrderInGroup phải lớn hơn 0.");
        }

        private void Normalize(AdminQuestionDTO dto)
        {
            dto.QuestionText = NormalizeText(dto.QuestionText);
            dto.Explanation = NormalizeText(dto.Explanation);
        }

        private string NormalizeText(string value)
        {
            return string.IsNullOrWhiteSpace(value) ? null : value.Trim();
        }
    }
}