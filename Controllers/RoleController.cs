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
    public class RoleController : Controller {
        private readonly ApplicationDbContext _context;
        public RoleController(ApplicationDbContext context) 
        {
            _context = context;
        }
        /// <summary>
        /// Lấy tất cả danh sách Roles
        /// </summary>
        /// <returns>Danh sách Roles</returns>
        [HttpGet]
        public IEnumerable<Role> Get() 
        {
            return _context.Role.ToList();
        }
        /// <summary>
        /// Lấy Roles với Id
        /// </summary>
        /// <returns>Danh sách Roles</returns>
        /// <param name="Id">Tham số là Id của Role</param>
        [HttpGet("Id")]
        public Role Get([FromQuery] int Id)
        {
            return _context.Role.Where(role => role.Id == Id).FirstOrDefault();
        }
        /// <summary>
        /// Thêm role mới
        /// </summary>
        /// <returns>Role</returns>
        [HttpPost]
        public Role Post([FromQuery] Role Role) {
            _context.Role.Add(Role);
            _context.SaveChanges();
            return Role ;
        }
    }
}
