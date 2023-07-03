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
    public class OrderController : Controller {
        private readonly ApplicationDbContext _context;
        public OrderController(ApplicationDbContext context) 
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Order> Get() 
        {
            return _context.Order.ToList();
        }
    }
}
