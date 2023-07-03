using System;
using System.ComponentModel.DataAnnotations;

namespace QLNH.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public int parentId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public bool Deleted { get; set; }
    }
}
