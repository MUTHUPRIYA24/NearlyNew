using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TermProject_NearlyNew.Controllers
{
    public class SellerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}