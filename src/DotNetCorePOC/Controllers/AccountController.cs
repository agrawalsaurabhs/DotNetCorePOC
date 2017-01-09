using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DotNetCorePOC.ViewModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using DotNetCorePOC.Models;
using Microsoft.AspNetCore.Identity;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace DotNetCorePOC.Controllers
{
    public class AccountController : Controller
    {
        private SignInManager<User> _signinmanager;
        private UserManager<User> _userservice;

        public AccountController(UserManager<User> userservice, SignInManager<User> signinManager)
        {
            _userservice = userservice;
            _signinmanager = signinManager;
        }


        public IActionResult Register()
        {
            var model = new RegisterUserViewModel();
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterUserViewModel user)
        {
            User newuser = new Models.User { UserName = user.Username };
            var createResult = await _userservice.CreateAsync(newuser, user.Password);
            if(createResult.Succeeded)
            {
                await _signinmanager.SignInAsync(newuser, false);
                return RedirectToAction("Address", "About");
            }
            else
            {
                //process the failure
                foreach(var error in createResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return RedirectToAction("Index","Home");
        }
    }
}
