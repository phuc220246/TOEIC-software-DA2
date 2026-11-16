using System.Collections.Generic;
using TOEIC_Practice.DAL.NoiDungDe;
using TOEIC_Practice.DTO.NoiDungDe;

namespace TOEIC_Practice.BLL.NoiDungDe
{
    public class PartBLL
    {
        private readonly PartDAL _dal = new PartDAL();

        public List<PartDTO> GetAll()
        {
            return _dal.GetAll();
        }
    }
}