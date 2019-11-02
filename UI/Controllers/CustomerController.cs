using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Library.Models;
using Library.Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    //NOTE:This controller and all its views are for testing purposes only
    public class CustomerController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }
    }
}