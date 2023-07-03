﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QLNH.Data;
using QLNH.Models;

namespace QLNH.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class LocationController : Controller {
        private readonly ApplicationDbContext _context;
        public LocationController(ApplicationDbContext context) {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Location> Get() {
            return _context.Location.ToList();
        }
    }
}
