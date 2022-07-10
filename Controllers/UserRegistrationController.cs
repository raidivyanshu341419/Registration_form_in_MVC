using Microsoft.AspNetCore.Mvc;
using Registration_form.Data;
using Registration_form.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Registration_form.Controllers
{
    public class UserRegistrationController : Controller
    {
        private readonly ApplicationUserContext _applicationUserContext;

        public UserRegistrationController(ApplicationUserContext applicationUserContext)
        {
            _applicationUserContext = applicationUserContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(User user)
        {
            _applicationUserContext.Add(user);
            _applicationUserContext.SaveChanges();
            ViewBag.message = "The user" + user.UserName + " is saved successfully";
            return View();
        }
    }
}
