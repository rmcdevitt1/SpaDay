using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;
using SpaDay.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            AddUserViewModel addUserViewModel = new AddUserViewModel();
            return View(addUserViewModel);
        }

        [HttpPost]
        [Route("/user")]
        public IActionResult SubmitAddUserForm(AddUserViewModel addUserViewModel)
        {

            //check that the value of Password is equal to VerifyPassword.
            //If it is, we can create an instance of User and pass it to the User/Index.cshtml view.
            //If the two passwords do not match, we need to reload the form with an error message displayed.
            if (ModelState.IsValid)
            {

                if (addUserViewModel.Password == addUserViewModel.VerifyPassword)
                {
                    User newUser = new User
                    {
                        Username = addUserViewModel.Username,
                        Email = addUserViewModel.Email,
                        Password = addUserViewModel.Password,
                        VerifyPassword = addUserViewModel.VerifyPassword

                    };
                    return View("Index", newUser);
                }
                else
                {
                    return View("add");
                }
            }
            else
            {
                return View(addUserViewModel);
                //or is it this way?: return View("add", addUserViewModel);//
            }

        }

    }
}
