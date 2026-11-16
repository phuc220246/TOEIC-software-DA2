using System.Collections.Generic;
using System.Data;
using TOEIC_Practice.DAL.Helpers;
using TOEIC_Practice.DTO.NoiDungDe;

namespace TOEIC_Practice.DAL.NoiDungDe
{
    public class EtsDAL
    {
        public List<EtsDTO> GetAll()
        {
            DataTable dt = DataHelper.Instance.ExecuteQuerySP("sp_Ets_List");
            List<EtsDTO> list = new List<EtsDTO>();

            foreach (DataRow row in dt.Rows)
                list.Add(new EtsDTO(row));

            return list;
        }
    }
}