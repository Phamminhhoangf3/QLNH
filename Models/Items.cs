using System.ComponentModel.DataAnnotations;

namespace QLNH.Models
{
    public class Items
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
