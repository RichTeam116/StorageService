using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StorageWebAPI.DTO;
using StorageWebAPI.Repository;
using StorageWebAPI.Models;

namespace StorageWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        ProductRepository pRep = new ProductRepository();

        [HttpPost]
        public IActionResult addProduct(ProductDTO postData)
        {
            Product product = new Product { Id = postData.Id, Name = postData.Name };
            pRep.addProduct(product);
            return Ok();
        }

        [HttpPut]
        public IActionResult editProduct(ProductDTO putdata)
        {
            Product product = new Product { Id = putdata.Id, Name = putdata.Name };
            pRep.updateProduct(product);
            return Ok();
        }
    }
}
