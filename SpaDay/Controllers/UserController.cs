using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        public UserController()
        {
        }

        [HttpGet]
        [Route("/user/add")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("user/add")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            // add form submission handling code here
            if (newUser.Password == verify)
            {
                ViewBag.username = newUser.Username;
                return View("Index");
            }else

            {
                ViewBag.error = "Passwords do not match. Please try again.";
                ViewBag.email = newUser.Email;
                ViewBag.username = newUser.Username;
                return View("Add");
            }

            
        }
    }
}
