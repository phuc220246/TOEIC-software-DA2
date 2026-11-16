using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TOEIC_Practice.DAL.Helpers;
using TOEIC_Practice.DTO.NoiDungDe;

namespace TOEIC_Practice.DAL.NoiDungDe
{
    public class TestDAL
    {
        public List<TestDTO> GetByEts(int etsId)
        {
            DataTable dt = DataHelper.Instance.ExecuteQuerySP(
                "sp_Test_ListByEts",
                new SqlParameter("@EtsId", etsId)
            );

            List<TestDTO> list = new List<TestDTO>();
            foreach (DataRow row in dt.Rows)
                list.Add(new TestDTO(row));

            return list;
        }
    }
}