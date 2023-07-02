using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QLNH.Models {
    public class User {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Password { get; set; }
    }
}
