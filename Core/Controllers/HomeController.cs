using System;
using Microsoft.AspNetCore.Mvc;
using Core.Models.Database;
using Core.Respositories;

namespace Core.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserRepository _userRepository;

        public HomeController(DatabaseContext databaseContext)
        {
            _userRepository = new UserRepository(databaseContext);
        }

        [HttpGet("/")]
        public ActionResult Index()
        {
            var email = "test@user.com";
            var user = _userRepository.GetByEmail(email);
            return View(user);
        }

        [HttpGet("/about")]
        public ActionResult About()
        {
            ViewBag.Message = "About!";
            ViewBag.Time = DateTime.Now;

            return View();
        }

        [HttpGet("/contact")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Contact!";
            ViewBag.Time = DateTime.Now;

            return View();
        }
    }
}
