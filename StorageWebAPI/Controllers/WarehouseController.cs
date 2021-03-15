using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StorageWebAPI.DTO;
using StorageWebAPI.Models;
using StorageWebAPI.Repository;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace StorageWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WarehouseController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetWarehouseList()
        {
            WarehouseRepository wHouseRep = new WarehouseRepository();

            List<Warehouse> wHouse = wHouseRep.getWarehouses();
            string result = JsonSerializer.Serialize(wHouse);
            return Content(result);
        }
    }
}