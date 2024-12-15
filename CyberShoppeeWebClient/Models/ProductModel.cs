using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CyberShoppeeWebClient.Models
{
    public class ProductModel
    {
      public int ProductId { get; set; }
      public int CategoryId { get; set; }
      public string ModelNumber { get; set; }
      public string ModelName { get; set; }
      public decimal UnitCost { get; set; }
      public string Description { get; set; }
    }
}
