using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StorageWebAPI.Models
{
    public class Storage
    {
        public long Id { get; set; }
        public Warehouse Warehouse { get; set; }
        public Product Product { get; set; }
        public int Value { get; set; }
    }
}
