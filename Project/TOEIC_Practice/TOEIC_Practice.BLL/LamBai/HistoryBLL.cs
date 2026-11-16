using System;
using System.Collections.Generic;
using System.Data;
using TOEIC_Practice.DAL.History;
using TOEIC_Practice.DTO.History;

namespace TOEIC_Practice.BLL.History
{
    public class HistoryBLL
    {
        private readonly HistoryDAL _dal = new HistoryDAL();

        public HistoryTestHeaderDTO GetTestHeader(int testId)
        {
            if (testId <= 0)
                throw new Exception("TestId không hợp lệ.");

            DataTable dt = _dal.GetTestHeader(testId);
            if (dt.Rows.Count == 0)
                return null;

            return new HistoryTestHeaderDTO(dt.Rows[0]);
        }

        public List<AttemptHistoryItemDTO> GetAttemptsByAccountAndTest(int accountId, int testId)
        {
            if (accountId <= 0)
                throw new Exception("AccountId không hợp lệ.");
            if (testId <= 0)
                throw new Exception("TestId không hợp lệ.");

            DataTable dt = _dal.GetAttemptsByAccountAndTest(accountId, testId);
            List<AttemptHistoryItemDTO> list = new List<AttemptHistoryItemDTO>();

            foreach (DataRow row in dt.Rows)
                list.Add(new AttemptHistoryItemDTO(row));

            return list;
        }

        public List<int> GetAttemptParts(int attemptId)
        {
            DataTable dt = _dal.GetAttemptParts(attemptId);
            List<int> parts = new List<int>();

            foreach (DataRow row in dt.Rows)
                parts.Add(Convert.ToInt32(row["PartId"]));

            return parts;
        }
    }
}