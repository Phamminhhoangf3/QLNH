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
    public class UnitTypeController : Controller {
        private readonly ApplicationDbContext _context;
        public UnitTypeController(ApplicationDbContext context) 
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<UnitType> Get() {
            return _context.UnitType.ToList();
        }
    }
}
