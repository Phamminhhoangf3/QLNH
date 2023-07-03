using System;
using System.ComponentModel.DataAnnotations;

namespace QLNH.Models
{
    public class ItemImage
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Data { get; set; }
        public string Description { get; set; }
        public DateTime Create { get; set; }
        public DateTime Update { get; set; }
        public bool Deleted { get; set; }
    }
}
