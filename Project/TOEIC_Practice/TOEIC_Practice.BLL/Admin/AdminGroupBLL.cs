using System;
using System.Collections.Generic;
using TOEIC_Practice.DAL;
using TOEIC_Practice.DAL.Admin;
using TOEIC_Practice.DTO;
using TOEIC_Practice.DTO.Admin;

namespace TOEIC_Practice.BLL.Admin
{
    public class AdminGroupBLL
    {
        private readonly AdminGroupDAL _dal = new AdminGroupDAL();

        public List<AdminQuestionGroupDTO> GetByTest(int testId)
        {
            if (testId <= 0) throw new Exception("TestId không hợp lệ.");
            return _dal.GetByTest(testId);
        }

        public List<AdminQuestionGroupDTO> GetByTestPart(int testId, int partId)
        {
            if (testId <= 0) throw new Exception("TestId không hợp lệ.");
            if (partId < 1 || partId > 7) throw new Exception("PartId không hợp lệ.");
            return _dal.GetByTestPart(testId, partId);
        }

        public AdminQuestionGroupDTO GetById(int groupId)
        {
            if (groupId <= 0) throw new Exception("GroupId không hợp lệ.");
            return _dal.GetById(groupId);
        }

        public int Create(AdminQuestionGroupDTO dto)
        {
            ValidateForCreate(dto);
            Normalize(dto);
            return _dal.Create(dto);
        }

        public void Update(AdminQuestionGroupDTO dto)
        {
            ValidateForUpdate(dto);
            Normalize(dto);
            _dal.Update(dto);
        }

        public void Deactivate(int groupId)
        {
            if (groupId <= 0) throw new Exception("GroupId không hợp lệ.");
            _dal.Deactivate(groupId);
        }

        private void ValidateForCreate(AdminQuestionGroupDTO dto)
        {
            if (dto == null) throw new Exception("Dữ liệu Group không hợp lệ.");
            if (dto.TestId <= 0) throw new Exception("Phải chọn Test.");
            if (dto.PartId < 1 || dto.PartId > 7) throw new Exception("PartId không hợp lệ.");
            ValidateCommon(dto);
        }

        private void ValidateForUpdate(AdminQuestionGroupDTO dto)
        {
            if (dto == null) throw new Exception("Dữ liệu Group không hợp lệ.");
            if (dto.GroupId <= 0) throw new Exception("GroupId không hợp lệ.");
            ValidateCommon(dto);
        }

        private void ValidateCommon(AdminQuestionGroupDTO dto)
        {
            if (dto.OrderNo <= 0) throw new Exception("OrderNo phải lớn hơn 0.");

            string groupType = (dto.GroupType ?? string.Empty).Trim().ToUpper();
            if (groupType != "SINGLE" && groupType != "CONVERSATION" && groupType != "PASSAGE")
                throw new Exception("GroupType chỉ nhận SINGLE, CONVERSATION hoặc PASSAGE.");

            dto.GroupType = groupType;

            if (dto.PartId == 1)
            {
                if (string.IsNullOrWhiteSpace(dto.AudioPath))
                    throw new Exception("Part 1 bắt buộc có AudioPath.");
                if (string.IsNullOrWhiteSpace(dto.ImagePath))
                    throw new Exception("Part 1 bắt buộc có ImagePath.");
            }

            if (dto.PartId == 2 || dto.PartId == 3 || dto.PartId == 4)
            {
                if (string.IsNullOrWhiteSpace(dto.AudioPath))
                    throw new Exception("Part này bắt buộc có AudioPath.");
            }

            if (!IsRelativeOrNull(dto.AudioPath))
                throw new Exception("AudioPath phải là đường dẫn tương đối.");

            if (!IsRelativeOrNull(dto.ImagePath))
                throw new Exception("ImagePath phải là đường dẫn tương đối.");
        }

        private void Normalize(AdminQuestionGroupDTO dto)
        {
            dto.GroupType = string.IsNullOrWhiteSpace(dto.GroupType) ? null : dto.GroupType.Trim().ToUpper();
            dto.AudioPath = NormalizeText(dto.AudioPath);
            dto.ImagePath = NormalizeText(dto.ImagePath);
            dto.PassageText = NormalizeText(dto.PassageText);
        }

        private string NormalizeText(string value)
        {
            return string.IsNullOrWhiteSpace(value) ? null : value.Trim();
        }

        private bool IsRelativeOrNull(string path)
        {
            if (string.IsNullOrWhiteSpace(path)) return true;
            if (path.Contains(":")) return false;
            if (path.StartsWith("\\") || path.StartsWith("/")) return false;
            return true;
        }
    }
}