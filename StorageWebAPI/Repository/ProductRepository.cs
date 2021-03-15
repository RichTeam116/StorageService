using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StorageWebAPI.Models;

namespace StorageWebAPI.Repository
{

    public class ProductRepository
    {
        private StorageContext db = new StorageContext();

        public bool addProduct(Product product)
        {
            try
            {
                db.Products.Add(product);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool updateProduct(Product product)
        {
            try
            {
                db.Products.Update(product);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
