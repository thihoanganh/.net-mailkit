using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.Net.Http.Headers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebApplication_Core_MVC_2.Entities;


namespace WebApplication_Core_MVC_2.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMailService mailService;
        public HomeController(IMailService _mailService)
        {
            mailService = _mailService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SendMail(MailContent content)
        {
            var rs = mailService.SendMail(content);
            return Content(rs.ToString());

        }
    }
}
