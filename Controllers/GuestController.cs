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
    public class GuestController : Controller {
        private readonly ApplicationDbContext _context;
        public GuestController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Guest> Get() 
        {
            return _context.Guest.ToList();
        }
    }
}
