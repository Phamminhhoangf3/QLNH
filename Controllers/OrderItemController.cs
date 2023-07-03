using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QLNH.Data;
using QLNH.Models;

namespace QLNH.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class OrderItemController : Controller {
        private readonly ApplicationDbContext _context;
        public OrderItemController(ApplicationDbContext context) 
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<OrderItem> Get() 
        {
            return _context.OrderItem.ToList();
        }
    }
}
