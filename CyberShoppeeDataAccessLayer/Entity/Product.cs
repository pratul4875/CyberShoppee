using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberShoppeeDataAccessLayer.Entity
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        [Required]
        [StringLength(50)]
        public string ModelNumber { get; set; }

        [Required]
        [StringLength(100)]
        public string ModelName { get; set; }

        [Range(0, double.MaxValue)]
        public decimal UnitCost { get; set; }

        public string Description { get; set; }
        public string img_url { get; set; }

        // Navigation property for foreign key relationship
        public Category Category { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
        public ICollection<ShoppingCart> ShoppingCarts { get; set; }
    }
}
