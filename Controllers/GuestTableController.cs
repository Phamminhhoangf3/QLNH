using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QLNH.Data;
using QLNH.Models;

namespace QLNH.Controllers {
    [ApiController]
    [Route("[Controller]")]
    public class GuestTableController : Controller {
        private readonly ApplicationDbContext _context;
        public GuestTableController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<GuestTable> Get() 
        {
            return _context.GuestTable.ToList();
        }
    }
}
