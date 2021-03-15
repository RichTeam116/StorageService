using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StorageWebAPI.Models;
using StorageWebAPI.DTO;

namespace StorageWebAPI.Repository
{

    public class WarehouseRepository
    {
        private StorageContext db = new StorageContext();

        public List<Warehouse> getWarehouses()
        {
            var wHouses = db.Warehouses.ToList();
            return wHouses;
        }
    }
}
