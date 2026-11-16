using System.Collections.Generic;
using TOEIC_Practice.DAL.NoiDungDe;
using TOEIC_Practice.DTO.NoiDungDe;

namespace TOEIC_Practice.BLL.NoiDungDe
{
    public class TestBLL
    {
        private readonly TestDAL _dal = new TestDAL();

        public List<TestDTO> GetByEts(int etsId)
        {
            return _dal.GetByEts(etsId);
        }
    }
}