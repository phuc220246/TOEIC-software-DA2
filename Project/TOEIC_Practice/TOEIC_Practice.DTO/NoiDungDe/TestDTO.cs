using System;
using System.Data;

namespace TOEIC_Practice.DTO.NoiDungDe
{
    public class TestDTO
    {
        public int TestId { get; set; }
        public int EtsId { get; set; }
        public int TestNo { get; set; }
        public string Title { get; set; }

        public TestDTO() { }

        public TestDTO(DataRow row)
        {
            TestId = Convert.ToInt32(row["TestId"]);
            EtsId = Convert.ToInt32(row["EtsId"]);
            TestNo = Convert.ToInt32(row["TestNo"]);
            Title = row["Title"] == DBNull.Value ? null : row["Title"].ToString();
        }
    }
}