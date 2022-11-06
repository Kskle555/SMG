using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WareHouseManager : IWareHouseService
    {
        IWareHouseDal _warehouseDal;
        public WareHouseManager(IWareHouseDal wareHouseDal)
        {
            _warehouseDal = wareHouseDal;
        }

        public List<WareHouse> GetList()
        {
            return _warehouseDal.GetListAll();
        }

        public void TAdd(WareHouse t)
        {
            _warehouseDal.Insert(t);
        }

        public void TDelete(WareHouse t)
        {
            throw new NotImplementedException();
        }

        public WareHouse TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(WareHouse t)
        {
            throw new NotImplementedException();
        }
    }
}
