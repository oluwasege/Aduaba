using System;
using System.ComponentModel.DataAnnotations;

namespace Aduaba.Models
{
    public class PaymentHistory
    {
        [Key]
        public string Id { get; set; }

        public virtual Order Order { get; set; }

        [Required]
        public string OrderNumber { get; set; }

        public virtual PaymentStatus PaymentStatus { get; set; }

        [Required]
        public int PaymentStatusId { get; set; }

        [Required]
        public DateTime LastModified { get; set; }
    }
}