using System.Collections.Generic;
using System.Data;
using TOEIC_Practice.DAL.Helpers;
using TOEIC_Practice.DTO.NoiDungDe;

namespace TOEIC_Practice.DAL.NoiDungDe
{
    public class PartDAL
    {
        public List<PartDTO> GetAll()
        {
            DataTable dt = DataHelper.Instance.ExecuteQuerySP("sp_Part_List");
            List<PartDTO> list = new List<PartDTO>();

            foreach (DataRow row in dt.Rows)
                list.Add(new PartDTO(row));

            return list;
        }
    }
}