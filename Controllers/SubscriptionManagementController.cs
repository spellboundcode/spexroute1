using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace spexroute1.Controllers
{
    public class SubscriptionManagementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetAll()
        {
            return View();
        }

    }
}