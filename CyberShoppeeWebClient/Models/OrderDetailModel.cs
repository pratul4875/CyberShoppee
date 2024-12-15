using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CyberShoppeeWebClient.Models
{
    public class OrderDetailModel
    {
      public int OrderDetailId { get; set; }
      public int OrderId { get; set; }
      public int ProductId { get; set; }
      public int Quantity { get; set; }
      public decimal UnitCost { get; set; }
    }
} 
