using System;
using System.Collections.Generic;
using TOEIC_Practice.BLL.Security;
using TOEIC_Practice.DAL;
using TOEIC_Practice.DAL.TaiKhoan;
using TOEIC_Practice.DTO;
using TOEIC_Practice.DTO.TaiKhoan;

namespace TOEIC_Practice.BLL
{
    public class AccountBLL
    {
        private readonly AccountDAL _dal = new AccountDAL();

        public AccountDTO Login(string username, string passwordPlain)
        {
            username = (username ?? "").Trim();
            passwordPlain = passwordPlain ?? "";

            if (string.IsNullOrWhiteSpace(username))
                throw new Exception("Tên đăng nhập không được để trống.");

            if (string.IsNullOrWhiteSpace(passwordPlain))
                throw new Exception("Mật khẩu không được để trống.");

            AccountDTO account = _dal.GetByUsername(username);
            if (account == null)
                throw new Exception("Tài khoản không tồn tại.");

            if (!account.IsActive)
                throw new Exception("Tài khoản đã bị khóa.");

            bool ok = PasswordHelper.VerifyPassword(
                passwordPlain,
                account.PasswordSalt,
                account.PasswordHash);

            if (!ok)
                throw new Exception("Sai mật khẩu.");

            List<string> roles = _dal.GetRoles(account.AccountId);

            Session.AccountId = account.AccountId;
            Session.Username = account.Username;
            Session.DisplayName = account.DisplayName;
            Session.Roles = roles;

            _dal.UpdateLastLogin(account.AccountId);

            return account;
        }

        public int CreateAccount(string username, string displayName, string passwordPlain)
        {
            username = (username ?? "").Trim();
            displayName = string.IsNullOrWhiteSpace(displayName) ? null : displayName.Trim();
            passwordPlain = passwordPlain ?? "";

            if (string.IsNullOrWhiteSpace(username))
                throw new Exception("Tên đăng nhập không được để trống.");

            if (username.Length > 50)
                throw new Exception("Tên đăng nhập tối đa 50 ký tự.");

            if (displayName != null && displayName.Length > 100)
                throw new Exception("Tên hiển thị tối đa 100 ký tự.");

            if (string.IsNullOrWhiteSpace(passwordPlain))
                throw new Exception("Mật khẩu không được để trống.");

            if (passwordPlain.Length < 6)
                throw new Exception("Mật khẩu phải có ít nhất 6 ký tự.");

            AccountDTO existed = _dal.GetByUsername(username);
            if (existed != null)
                throw new Exception("Tên đăng nhập đã tồn tại.");

            byte[] salt = PasswordHelper.CreateSalt();
            byte[] hash = PasswordHelper.HashPassword(passwordPlain, salt);

            return _dal.CreateAccount(username, displayName, hash, salt);
        }

        public void AssignRole(int accountId, string roleName)
        {
            if (accountId <= 0)
                throw new Exception("AccountId không hợp lệ.");

            roleName = (roleName ?? "").Trim();
            if (string.IsNullOrWhiteSpace(roleName))
                throw new Exception("RoleName không được để trống.");

            _dal.AssignRole(accountId, roleName);
        }
    }
}