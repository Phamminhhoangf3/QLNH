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
    public class UserController : Controller {
        private readonly ApplicationDbContext _context;
        public UserController(ApplicationDbContext context) {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<User> Get() {
            return _context.User.ToList();
        }
    }
}
