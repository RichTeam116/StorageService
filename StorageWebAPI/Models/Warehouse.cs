using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StorageWebAPI.Models
{
    public class Warehouse
    {
        public long Id { get; set; }
        public int Number { get; set; }
        public Storage Storage { get; set; }
    }
}
