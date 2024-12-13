using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CyberShoppeeApi.CyberShoppeeRepository
{
    public class ProductDataUnavailableException : Exception
    {
        public ProductDataUnavailableException(string message):base(message) { }
        
    }
    public class OrderDataUnavailableException : Exception
    {
        public OrderDataUnavailableException(string message) : base(message) { }

    }
    public class OrderDetailDataUnavailableException : Exception
    {
        public OrderDetailDataUnavailableException(string message) : base(message) { }

    }
    public class CategoriesDataUnavailableException : Exception
    {
        public CategoriesDataUnavailableException(string message) : base(message) { }

    }
    public class ShoppingcartDataUnavailableException : Exception
    {
        public ShoppingcartDataUnavailableException(string message) : base(message) { }

    }
    public class CutomerDataUnavailableException : Exception
    {
        public CutomerDataUnavailableException(string message) : base(message) { }

    }

}