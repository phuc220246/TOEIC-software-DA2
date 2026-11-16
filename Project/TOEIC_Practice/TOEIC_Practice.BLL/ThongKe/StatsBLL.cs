using System;
using System.Collections.Generic;
using System.Data;
using TOEIC_Practice.DAL.Stats;
using TOEIC_Practice.DTO.Stats;

namespace TOEIC_Practice.BLL.Stats
{
    public class StatsBLL
    {
        private readonly StatsDAL _dal = new StatsDAL();

        public StatsOverviewDTO GetOverviewByAccount(int accountId)
        {
            if (accountId <= 0)
                throw new Exception("AccountId không hợp lệ.");

            DataTable dt = _dal.GetOverviewByAccount(accountId);
            if (dt.Rows.Count == 0)
                return new StatsOverviewDTO();

            return new StatsOverviewDTO(dt.Rows[0]);
        }

        public List<StatsByPartDTO> GetByPart(int accountId)
        {
            if (accountId <= 0)
                throw new Exception("AccountId không hợp lệ.");

            DataTable dt = _dal.GetByPart(accountId);
            List<StatsByPartDTO> list = new List<StatsByPartDTO>();

            foreach (DataRow row in dt.Rows)
                list.Add(new StatsByPartDTO(row));

            return list;
        }

        public List<StatsByTestDTO> GetByTest(int accountId)
        {
            if (accountId <= 0)
                throw new Exception("AccountId không hợp lệ.");

            DataTable dt = _dal.GetByTest(accountId);
            List<StatsByTestDTO> list = new List<StatsByTestDTO>();

            foreach (DataRow row in dt.Rows)
                list.Add(new StatsByTestDTO(row));

            return list;
        }

        public List<RecentAttemptStatsDTO> GetRecentAttempts(int accountId, int topN = 10)
        {
            if (accountId <= 0)
                throw new Exception("AccountId không hợp lệ.");

            DataTable dt = _dal.GetRecentAttempts(accountId, topN);
            List<RecentAttemptStatsDTO> list = new List<RecentAttemptStatsDTO>();

            foreach (DataRow row in dt.Rows)
                list.Add(new RecentAttemptStatsDTO(row));

            return list;
        }
    }
}