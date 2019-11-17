using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Data.MainRepository.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace UI.Areas.Customer.Controllers
{
    public class CustomerTravelPackageController : Controller
    {
        private CustomerTravelPackageRepository _ctpr;
        private readonly UserManager<IdentityUser> _userManager;


        public CustomerTravelPackageController(CustomerTravelPackageRepository ctpr, UserManager<IdentityUser> userMananger)
        {
            _ctpr = ctpr;
            _userManager = userMananger;
        }

        public IActionResult Index()
        {
            var foo = _userManager.GetUserId();
            return View();
        }
    }
}