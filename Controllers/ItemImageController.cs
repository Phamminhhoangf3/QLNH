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
    public class ItemImageController : Controller {
        private readonly ApplicationDbContext _context;
        public ItemImageController(ApplicationDbContext context) {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<ItemImage> Get() {
            return _context.ItemImage.ToList();
        }
    }
}
