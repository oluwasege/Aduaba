using System.ComponentModel.DataAnnotations;

namespace Aduaba.Models
{
    public class OrderStatus
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public bool HasBeenShipped { get; set; }
    }
}