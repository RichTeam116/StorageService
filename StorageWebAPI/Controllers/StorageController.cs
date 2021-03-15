using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StorageWebAPI.DTO;
using StorageWebAPI.Models;
using StorageWebAPI.Repository;

namespace StorageWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StorageController : ControllerBase
    {
        StorageRepository sRep = new StorageRepository();

        [HttpPost]
        public IActionResult addStorage(StorageDTO postData)
        {
            sRep.addStorage(postData.ProductId,postData.StorageId,postData.Value);
            return Ok();
        }

        [HttpPut]
        public IActionResult editStorage(StorageDTO putdata)
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult deleteStorage(StorageDTO deleteData)
        {
            return Ok();
        }
    }
}
