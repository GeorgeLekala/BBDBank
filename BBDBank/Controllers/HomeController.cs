using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BBDBank.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ChallengePanel()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult ChallengeList()
        {
            ViewData["Message"] = "Available challenges.";

            return View();
        }

        public IActionResult CreateChallenge()
        {
            ViewData["Message"] = "Make a challenge";

            return View();
        }

        public IActionResult DoChallenge()
        {
            ViewData["Message"] = "Compete";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
