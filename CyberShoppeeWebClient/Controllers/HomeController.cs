using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using CyberShoppeeDataAccessLayer.Entity;
using Newtonsoft.Json;

namespace CyberShoppeeWebClient.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            // get products from http://localhost:49987/api/products/LatestProducts and send them to View
            using (HttpClient client = new HttpClient())
            {
                var response = client.GetAsync("http://localhost:49987/api/products/LatestProducts").Result;
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = response.Content.ReadAsStringAsync().Result;
                    var products = JsonConvert.DeserializeObject<List<Product>>(jsonString);
                    return View(products);
                }
                return View();
            }
        }
    }
}
