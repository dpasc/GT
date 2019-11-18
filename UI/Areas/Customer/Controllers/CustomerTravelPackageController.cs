using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Domain.Data.MainRepository.Repositories;
using Library.Models.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace UI.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class CustomerTravelPackageController : Controller
    {
        private CustomerTravelPackageRepository _ctpr;
       
       
        public CustomerTravelPackageController(CustomerTravelPackageRepository ctpr)
        {
            _ctpr = ctpr;            
        }


        [HttpGet]
        public IActionResult Index(TravelPackage travelPackage)
        {
            return View(travelPackage);
        }




        [HttpPost,]
        public async Task<IActionResult> IndexSend(TravelPackage travelPackage)
        {
        
            Person customer = await _ctpr.GetCustomerByUserId(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var cpa = new CustomerTravelPackage();
            cpa.CustomerId = customer.Id;
            cpa.TravelPackageId = travelPackage.Id;
            cpa.SalePrice = travelPackage.RRP;
            cpa.StartDate = DateTime.Now;

             await _ctpr.Add(cpa);

            return View(customer);
        }
    }
}