using System;
using Microsoft.AspNetCore.Mvc;
using UI.Mappers;
using Core.Interfaces;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserRepository _userRepository;

        public HomeController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet("/")]
        public ActionResult Index()
        {
            var email = "test@user.com";
            var user = _userRepository.GetByEmail(email);

            var userViewModel = UserViewModelMapper.MapFrom(user);
            return View(userViewModel);
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
