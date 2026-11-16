using System;
using System.Collections.Generic;
using TOEIC_Practice.DAL;
using TOEIC_Practice.DAL.Admin;
using TOEIC_Practice.DTO;
using TOEIC_Practice.DTO.Admin;

namespace TOEIC_Practice.BLL.Admin
{
    public class AdminTestBLL
    {
        private readonly AdminTestDAL _dal = new AdminTestDAL();

        public List<AdminTestDTO> GetAll()
        {
            return _dal.GetAll();
        }

        public List<AdminTestDTO> GetByEts(int etsId)
        {
            if (etsId <= 0) throw new Exception("EtsId không hợp lệ.");
            return _dal.GetByEts(etsId);
        }

        public AdminTestDTO GetById(int testId)
        {
            if (testId <= 0) throw new Exception("TestId không hợp lệ.");
            return _dal.GetById(testId);
        }

        public int Create(AdminTestDTO dto)
        {
            ValidateForCreate(dto);
            dto.Title = Normalize(dto.Title);
            return _dal.Create(dto);
        }

        public void Update(AdminTestDTO dto)
        {
            ValidateForUpdate(dto);
            dto.Title = Normalize(dto.Title);
            _dal.Update(dto);
        }

        public void Deactivate(int testId)
        {
            if (testId <= 0) throw new Exception("TestId không hợp lệ.");
            _dal.Deactivate(testId);
        }

        private void ValidateForCreate(AdminTestDTO dto)
        {
            if (dto == null) throw new Exception("Dữ liệu Test không hợp lệ.");
            if (dto.EtsId <= 0) throw new Exception("Phải chọn ETS.");
            if (dto.TestNo <= 0) throw new Exception("TestNo không hợp lệ.");
        }

        private void ValidateForUpdate(AdminTestDTO dto)
        {
            if (dto == null) throw new Exception("Dữ liệu Test không hợp lệ.");
            if (dto.TestId <= 0) throw new Exception("TestId không hợp lệ.");
        }

        private string Normalize(string value)
        {
            return string.IsNullOrWhiteSpace(value) ? null : value.Trim();
        }
    }
}