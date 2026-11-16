using System;
using System.Data;

namespace TOEIC_Practice.DTO.Admin
{
    public class AdminStatsPartAccuracyDTO
    {
        public int PartId { get; set; }
        public string PartName { get; set; }
        public int TotalAnswered { get; set; }
        public int CorrectCount { get; set; }
        public int WrongCount { get; set; }
        public decimal AccuracyPercent { get; set; }

        public AdminStatsPartAccuracyDTO() { }

        public AdminStatsPartAccuracyDTO(DataRow row)
        {
            PartId = row["PartId"] == DBNull.Value ? 0 : Convert.ToInt32(row["PartId"]);
            PartName = row["PartName"] == DBNull.Value ? "" : row["PartName"].ToString();
            TotalAnswered = row["TotalAnswered"] == DBNull.Value ? 0 : Convert.ToInt32(row["TotalAnswered"]);
            CorrectCount = row["CorrectCount"] == DBNull.Value ? 0 : Convert.ToInt32(row["CorrectCount"]);
            WrongCount = row["WrongCount"] == DBNull.Value ? 0 : Convert.ToInt32(row["WrongCount"]);
            AccuracyPercent = row["AccuracyPercent"] == DBNull.Value ? 0 : Convert.ToDecimal(row["AccuracyPercent"]);
        }
    }
}