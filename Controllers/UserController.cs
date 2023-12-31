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
    public class UserController : Controller {
        private readonly ApplicationDbContext _context;
        public UserController(ApplicationDbContext context) {
            _context = context;
        }
        /// <summary>
        /// Lấy tất cả danh sách Users
        /// </summary>
        /// <returns>Danh sách Users</returns>
        [HttpGet]
        public IEnumerable<User> Get() {
            return _context.User.ToList();
        }
        /// <summary>
        /// Lấy user với Id
        /// </summary>
        /// <returns>User</returns>
        /// <param name="Id">Tham số là Id của User</param> 
        [HttpGet("Id")]
        public Object Get([FromQuery] int Id) {
            return _context.User.Where(user => user.Id == Id).Select(s => new {
                Id = s.Id,
                UserName = s.UserName
            }).FirstOrDefault();
        }
        /// <summary>
        /// Thêm user mới
        /// </summary>
        /// <returns>Danh sách Users</returns>
        [HttpPost]
        public User Post([FromQuery] User User) {
            _context.User.Add(User);
            _context.SaveChanges();
            return User;
        }
        /// <summary>
        /// Cập nhật user
        /// </summary>
        /// <returns>Danh sách Users</returns>
        [HttpPut]
        public User Put([FromQuery] User User) {
            var user = _context.User.Find(User.Id);
            if (user == null) {
                return null;
            }
            user.UserName = User.UserName;
            user.Password = User.Password;
            _context.SaveChanges();
            return user;
        }
    }
}
