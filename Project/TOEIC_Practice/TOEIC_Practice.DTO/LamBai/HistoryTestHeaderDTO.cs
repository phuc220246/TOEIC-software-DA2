using System;
using System.Data;

namespace TOEIC_Practice.DTO.History
{
    public class HistoryTestHeaderDTO
    {
        public int TestId { get; set; }
        public int EtsYear { get; set; }
        public int TestNo { get; set; }
        public string TestTitle { get; set; }
        public string TestDisplayTitle { get; set; }

        public HistoryTestHeaderDTO() { }

        public HistoryTestHeaderDTO(DataRow row)
        {
            TestId = row.Table.Columns.Contains("TestId") ? Convert.ToInt32(row["TestId"]) : 0;
            EtsYear = row.Table.Columns.Contains("EtsYear") ? Convert.ToInt32(row["EtsYear"]) : 0;
            TestNo = row.Table.Columns.Contains("TestNo") ? Convert.ToInt32(row["TestNo"]) : 0;
            TestTitle = row.Table.Columns.Contains("TestTitle") && row["TestTitle"] != DBNull.Value
                ? row["TestTitle"].ToString()
                : string.Empty;
            TestDisplayTitle = row.Table.Columns.Contains("TestDisplayTitle") && row["TestDisplayTitle"] != DBNull.Value
                ? row["TestDisplayTitle"].ToString()
                : string.Empty;
        }
    }
}