using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CyberShoppeeWebClient.Models
{
    public class ShoppingCartModel
    {
       public int RecordId { get; set; }
       public int CartId { get; set; }
       public int Quantity { get; set; }
       public int ProductId { get; set; }
       public DateTime DateCreated { get; set; }
    }
}
