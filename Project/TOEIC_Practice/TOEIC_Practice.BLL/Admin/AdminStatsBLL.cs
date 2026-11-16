using System;
using System.Collections.Generic;
using TOEIC_Practice.DAL.Admin;
using TOEIC_Practice.DTO.Admin;

namespace TOEIC_Practice.BLL.Admin
{
    public class AdminStatsBLL
    {
        private readonly AdminStatsDAL _dal = new AdminStatsDAL();

        public AdminStatsOverviewDTO GetOverview()
        {
            return _dal.GetOverview();
        }

        public List<AdminStatsPartAccuracyDTO> GetAccuracyByPart()
        {
            return _dal.GetAccuracyByPart();
        }

        public List<AdminStatsByTestDTO> GetByTest()
        {
            return _dal.GetByTest();
        }

        public AdminStatsAccountOverviewDTO GetOverviewByAccount(int accountId)
        {
            if (accountId <= 0)
                throw new Exception("AccountId không hợp lệ.");

            return _dal.GetOverviewByAccount(accountId);
        }

        public List<AdminStatsPartAccuracyDTO> GetAccuracyByPartByAccount(int accountId)
        {
            if (accountId <= 0)
                throw new Exception("AccountId không hợp lệ.");

            return _dal.GetAccuracyByPartByAccount(accountId);
        }

        public List<AdminStatsRecentAttemptDTO> GetRecentAttemptsByAccount(int accountId)
        {
            if (accountId <= 0)
                throw new Exception("AccountId không hợp lệ.");

            return _dal.GetRecentAttemptsByAccount(accountId);
        }
    }
}