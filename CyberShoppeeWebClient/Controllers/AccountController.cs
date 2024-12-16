

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using CyberShoppeeDataAccessLayer.Entity;
using CyberShoppeeWebClient.Models;
using Newtonsoft.Json;

namespace CyberShoppeeWebClient.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                using (HttpClient client = new HttpClient())
                {
                    StringContent content = new StringContent(JsonConvert.SerializeObject(model), System.Text.Encoding.UTF8, "application/json");
                    var response = client.PostAsync("http://localhost:49987/api/customers/validate", content);
                    if (response.Result.IsSuccessStatusCode)
                    {
                        Session["user"] = model.Email;
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        return RedirectToAction("Error", "Account");
                    }
                }
            }
            return View(model); // Ensure the model is passed back to the view
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login", "Account");
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Customer customer)
        {
            if (ModelState.IsValid)
            {
                using (HttpClient client = new HttpClient())
                {
                    StringContent content = new StringContent(JsonConvert.SerializeObject(customer), System.Text.Encoding.UTF8, "application/json");
                    var response = client.PostAsync("http://localhost:49987/api/customers/register", content);
                    if (response.Result.IsSuccessStatusCode)
                    {
                        TempData["Message"] = "Registration Successful. Please Login.";
                        return RedirectToAction("Login", "Account");
                    }
                    else
                    {
                        // redirect to error page in shared
                        return RedirectToAction("Error", "Account");
                    }
                }
            }

            // If we got this far, something failed, redisplay form
            return View(customer);
        }

        public ActionResult Error()
        {
            return View();
        }



    }
}