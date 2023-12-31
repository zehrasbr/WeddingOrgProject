﻿using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WeddingOrganization.PresantationLayer.Models;

namespace SocialMedia.WebUI.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(UserRegisterViewModel p)
        {
            //AppUser appUser = new AppUser()
            //{
            //    UserName = p.UserName,
            //    Email = p.Email,
            //};
            //if (p.Password == p.ConfirmPassword)
            //{
            //    var result = await _userManager.CreateAsync(appUser, p.Password);

            //    if (result.Succeeded)
            //    {
            //        return RedirectToAction("SignIn");
            //    }
            //    else
            //    {
            //        foreach (var item in result.Errors)
            //        {
            //            ModelState.AddModelError("", item.Description);
            //        }
            //    }
            //}
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser()
                {
                    UserName = p.UserName,
                    Email = p.Email,
                    Password = p.Password,
                };
                var result = await _userManager.CreateAsync(appUser, p.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("SignIn", "Login");
                }
            }
            return View();
        }
        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignIn(UserSignInViewModel p)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(p.UserName, p.Password, false, true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Default");
                }
                else
                {
                    return RedirectToAction("SignIn", "Login");
                }
            }
            return View();
        }
    }
}
