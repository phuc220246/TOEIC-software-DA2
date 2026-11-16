using System.Collections.Generic;
using TOEIC_Practice.DAL.NoiDungDe;
using TOEIC_Practice.DTO.NoiDungDe;

namespace TOEIC_Practice.BLL.NoiDungDe
{
    public class EtsBLL
    {
        private readonly EtsDAL _dal = new EtsDAL();

        public List<EtsDTO> GetAll()
        {
            return _dal.GetAll();
        }
    }
}