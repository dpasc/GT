﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UI.Areas.Purchase.Controllers
{
    [Area("Purchase")]
    public class PurchaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}