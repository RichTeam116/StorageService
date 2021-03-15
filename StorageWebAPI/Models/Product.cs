using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StorageWebAPI.Models
{
    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public List<Storage> Storage = new List<Storage>();
    }
}
