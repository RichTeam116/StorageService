using StorageWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StorageWebAPI.Repository
{

    public class StorageRepository
    {
        private StorageContext db = new StorageContext();
        
        public bool addStorage(int productId, int storageId, int value)
        {
            try
            {
                Product product = (Product)db.Products.Where(t => t.Id == productId);
                Warehouse warehouse = (Warehouse)db.Warehouses.Where(t => t.Id == storageId);

                Storage storage = new Storage { Product = product, Warehouse = warehouse, Value = value };
                db.Storages.Add(storage);
            }
            catch
            {
                return false;
            }
            return true;
        }
        
        public bool updateStorage(Storage storage)
        {
            try
            {
                db.Storages.Update(storage);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool deleteStorage(Storage storage)
        {
            try
            {
                db.Storages.Remove(storage);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
