using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CartApi.Controllers
{
    [Route("api")]
    [ApiController]
    public class CartController : ControllerBase
    {
        [HttpGet("Cart")]
        public ActionResult Get()
        {
            var cart = new { productName="Laptop",Piece=1,Price=500 };
            return Ok(cart);
        }
    }
}
