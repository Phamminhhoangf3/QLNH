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
    public class RoleController : Controller {
        private readonly ApplicationDbContext _context;
        public RoleController(ApplicationDbContext context) 
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Role> Get() 
        {
            return _context.Role.ToList();
        }
    }
}
