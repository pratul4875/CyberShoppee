using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberShoppeeDataAccessLayer.Entity
{
    public class ShoppingCart
    {
        [Key]
        public int RecordId { get; set; }
        [Required]
        public string CartId { get; set; }
        public int Quantity { get; set; }
        [Required]
        public int ProductId { get; set; }
        public DateTime DateCreated { get; set; }
        // Foreign key relationship
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
    }
}
