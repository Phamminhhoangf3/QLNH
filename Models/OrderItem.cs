using System;
using System.ComponentModel.DataAnnotations;

namespace QLNH.Models
{
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public bool Deteled { get; set; }
        public bool Voided { get; set; }
        public double SalePrice { get; set; }
        public virtual Item Item { get; set; }
    }
}
