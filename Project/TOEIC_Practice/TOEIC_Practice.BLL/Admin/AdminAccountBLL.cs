using System;
using System.Collections.Generic;
using TOEIC_Practice.BLL.Security;
using TOEIC_Practice.DAL.Admin;
using TOEIC_Practice.DTO;
using TOEIC_Practice.DTO.Admin;

namespace TOEIC_Practice.BLL.Admin
{
    public class AdminAccountBLL
    {
        private readonly AdminAccountDAL _dal = new AdminAccountDAL();

        public List<AdminAccountDTO> GetAll()
        {
            return _dal.ListAll();
        }

        public List<AdminAccountDTO> Search(string keyword)
        {
            keyword = (keyword ?? "").Trim();

            if (string.IsNullOrWhiteSpace(keyword))
                return _dal.ListAll();

            return _dal.Search(keyword);
        }

        public AdminAccountDTO GetById(int accountId)
        {
            if (accountId <= 0)
                throw new Exception("AccountId không hợp lệ.");

            return _dal.GetById(accountId);
        }

        public List<AdminRoleDTO> GetRoles()
        {
            return _dal.ListRoles();
        }

        public int Create(string username, string displayName, string passwordPlain, string confirmPassword, string roleName, bool isActive)
        {
            username = (username ?? "").Trim();
            displayName = string.IsNullOrWhiteSpace(displayName) ? null : displayName.Trim();
            passwordPlain = passwordPlain ?? "";
            confirmPassword = confirmPassword ?? "";
            roleName = (roleName ?? "").Trim();

            if (string.IsNullOrWhiteSpace(username))
                throw new Exception("Username không được để trống.");

            if (username.Length > 50)
                throw new Exception("Username tối đa 50 ký tự.");

            if (displayName != null && displayName.Length > 100)
                throw new Exception("DisplayName tối đa 100 ký tự.");

            if (string.IsNullOrWhiteSpace(passwordPlain))
                throw new Exception("Mật khẩu không được để trống.");

            if (passwordPlain.Length < 6)
                throw new Exception("Mật khẩu phải có ít nhất 6 ký tự.");

            if (passwordPlain != confirmPassword)
                throw new Exception("Xác nhận mật khẩu không khớp.");

            if (string.IsNullOrWhiteSpace(roleName))
                throw new Exception("Bạn chưa chọn Role.");

            byte[] salt = PasswordHelper.CreateSalt();
            byte[] hash = PasswordHelper.HashPassword(passwordPlain, salt);

            return _dal.Create(username, displayName, hash, salt, roleName, isActive);
        }

        public void Update(int accountId, string displayName, string roleName, bool isActive)
        {
            if (accountId <= 0)
                throw new Exception("AccountId không hợp lệ.");

            displayName = string.IsNullOrWhiteSpace(displayName) ? null : displayName.Trim();
            roleName = (roleName ?? "").Trim();

            if (displayName != null && displayName.Length > 100)
                throw new Exception("DisplayName tối đa 100 ký tự.");

            if (string.IsNullOrWhiteSpace(roleName))
                throw new Exception("Bạn chưa chọn Role.");

            if (accountId == Session.AccountId && !isActive)
                throw new Exception("Bạn không thể tự khóa chính tài khoản đang đăng nhập.");

            _dal.Update(accountId, displayName, roleName, isActive);
        }

        public void SetActive(int accountId, bool isActive)
        {
            if (accountId <= 0)
                throw new Exception("AccountId không hợp lệ.");

            if (accountId == Session.AccountId && !isActive)
                throw new Exception("Bạn không thể tự khóa chính tài khoản đang đăng nhập.");

            _dal.SetActive(accountId, isActive);
        }

        public void ResetPassword(int accountId, string newPassword, string confirmPassword)
        {
            if (accountId <= 0)
                throw new Exception("AccountId không hợp lệ.");

            newPassword = newPassword ?? "";
            confirmPassword = confirmPassword ?? "";

            if (string.IsNullOrWhiteSpace(newPassword))
                throw new Exception("Mật khẩu mới không được để trống.");

            if (newPassword.Length < 6)
                throw new Exception("Mật khẩu mới phải có ít nhất 6 ký tự.");

            if (newPassword != confirmPassword)
                throw new Exception("Xác nhận mật khẩu không khớp.");

            byte[] salt = PasswordHelper.CreateSalt();
            byte[] hash = PasswordHelper.HashPassword(newPassword, salt);

            _dal.ResetPassword(accountId, hash, salt);
        }
    }
}