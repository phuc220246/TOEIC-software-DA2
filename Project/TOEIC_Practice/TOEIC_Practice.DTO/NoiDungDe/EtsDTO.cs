using System;
using System.Data;

namespace TOEIC_Practice.DTO.NoiDungDe
{
    public class EtsDTO
    {
        public int EtsId { get; set; }
        public int Year { get; set; }
        public string Title { get; set; }

        public EtsDTO() { }

        public EtsDTO(DataRow row)
        {
            EtsId = Convert.ToInt32(row["EtsId"]);
            Year = Convert.ToInt32(row["Year"]);
            Title = row["Title"] == DBNull.Value ? null : row["Title"].ToString();
        }
    }
}