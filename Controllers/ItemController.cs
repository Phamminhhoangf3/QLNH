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
    public class ItemController : Controller {
        private readonly ApplicationDbContext _context;
        public ItemController(ApplicationDbContext context) {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Item> Get() {
            return _context.Item.ToList();
        }
    }
}
