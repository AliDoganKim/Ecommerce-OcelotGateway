using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OrderApi.Controllers
{
    [Route("api")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        
        public class Order
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public Order(int id,string name)
            {
                Id = id;
                Name = name;
            }
        }

        [HttpGet("Order")]
        public ActionResult Get()
        {
            var order1 = new Order(1,"Laptop");
            var order2 = new Order(1,"Desktop");
            return Ok(new List<Order> { order1,order2 });
        }



    }
}
