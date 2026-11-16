using System;
using System.Collections.Generic;
using TOEIC_Practice.DAL;
using TOEIC_Practice.DAL.Admin;
using TOEIC_Practice.DTO;
using TOEIC_Practice.DTO.Admin;

namespace TOEIC_Practice.BLL.Admin
{
    public class AdminEtsBLL
    {
        private readonly AdminEtsDAL _dal = new AdminEtsDAL();

        public List<AdminEtsDTO> GetAll()
        {
            return _dal.GetAll();
        }

        public AdminEtsDTO GetById(int etsId)
        {
            if (etsId <= 0) throw new Exception("EtsId không hợp lệ.");
            return _dal.GetById(etsId);
        }

        public int Create(AdminEtsDTO dto)
        {
            ValidateForCreate(dto);
            dto.Title = Normalize(dto.Title);
            return _dal.Create(dto);
        }

        public void Update(AdminEtsDTO dto)
        {
            ValidateForUpdate(dto);
            dto.Title = Normalize(dto.Title);
            _dal.Update(dto);
        }

        public void Deactivate(int etsId)
        {
            if (etsId <= 0) throw new Exception("EtsId không hợp lệ.");
            _dal.Deactivate(etsId);
        }

        private void ValidateForCreate(AdminEtsDTO dto)
        {
            if (dto == null) throw new Exception("Dữ liệu ETS không hợp lệ.");
            if (dto.Year <= 0) throw new Exception("Year không hợp lệ.");
        }

        private void ValidateForUpdate(AdminEtsDTO dto)
        {
            if (dto == null) throw new Exception("Dữ liệu ETS không hợp lệ.");
            if (dto.EtsId <= 0) throw new Exception("EtsId không hợp lệ.");
            if (dto.Year <= 0) throw new Exception("Year không hợp lệ.");
        }

        private string Normalize(string value)
        {
            return string.IsNullOrWhiteSpace(value) ? null : value.Trim();
        }
    }
}