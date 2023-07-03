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
    public class UnitController : Controller {
        private readonly ApplicationDbContext _context;
        public UnitController(ApplicationDbContext context) 
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Unit> Get() {
            return _context.Unit.ToList();
        }
    }
}
