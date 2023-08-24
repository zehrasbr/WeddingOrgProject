﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MailKit.Net.Smtp;
using SocialMedia.WebUI.Models;
using System.Net.Mail;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;
using Microsoft.AspNetCore.Authorization;
using EntityLayer.Concrete;

namespace SocialMedia.WebUI.Controllers
{
    [AllowAnonymous]
    public class PasswordChangeController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public PasswordChangeController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult ForgetPassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ForgetPassword(ForgetPasswordViewModel forgetPasswordViewModel)
        {
            var user = await _userManager.FindByEmailAsync(forgetPasswordViewModel.Mail);
            string passwordResetToken = await _userManager.GeneratePasswordResetTokenAsync(user);
            var passwordResetTokenLink = Url.Action("ResetPassword","PasswordChange",new
            {
                userId = user.Id,
                token = passwordResetToken
            },HttpContext.Request.Scheme);

            MimeMessage mimeMessage = new MimeMessage();

            MailboxAddress mailboxAddressFrom = new MailboxAddress("","zehraisbr@gmail.com");

            mimeMessage.From.Add(mailboxAddressFrom);

            MailboxAddress mailboxAddressToo = new MailboxAddress("",forgetPasswordViewModel.Mail);
            mimeMessage.To.Add(mailboxAddressToo);

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = passwordResetTokenLink;
            mimeMessage.Body = bodyBuilder.ToMessageBody();

            mimeMessage.Subject = "Şifre Değişiklik Talebi";

            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, false);
            client.Authenticate("zehraisbr@gmail.com", "fyanzxgrietjfgcp");
            client.Send(mimeMessage);
            client.Disconnect(true);

            return View();
        }
        [HttpGet]
        public IActionResult ResetPassword(string userid, string token)
        {
            TempData["userid"] = userid;
            TempData["token"] = token;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel resetPasswordViewModel)
        {
            var userid = TempData["userid"];
            var token = TempData["token"];
            if(userid == null || token==null)
            {
                
            }
            var user = await _userManager.FindByIdAsync(userid.ToString());
            var result = await _userManager.ResetPasswordAsync(user,token.ToString(),resetPasswordViewModel.Password);
            if(result.Succeeded)
            {
                return RedirectToAction("SignIn", "Login");
            }
            return View();
        }
    }
}
