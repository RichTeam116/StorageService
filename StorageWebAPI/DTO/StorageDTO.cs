using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StorageWebAPI.DTO
{
    public class StorageDTO
    {
        public int Id { get; set; }
        public int StorageId { get; set; }
        public int ProductId { get; set; }
        public int Value { get; set; }
    }
}