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
        public async Task<IActionResult> Index(TravelPackage travelPackage)
        {
            Person customer = await _ctpr.GetCustomerByUserId(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var cpa = new CustomerTravelPackage();
            cpa.CustomerId = customer.Id;
            cpa.TravelPackageId = travelPackage.Id;
            cpa.SalePrice = travelPackage.RRP;
            cpa.StartDate = DateTime.Now;
            cpa.Id = 0;
            return View(cpa);
        }


        [HttpPost, ActionName("Index")]
        public async Task<IActionResult> IndexSend(CustomerTravelPackage cpa)
        {
            cpa.Id = 0;
            await _ctpr.Add(cpa);
            return RedirectToAction();
        }


        //Leave feedback
        [HttpGet]
        public async Task<IActionResult>LeaveFeedback(int id)
        {
            var ctp =await _ctpr.Get(id);
            return View(ctp);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>LeaveFeedback(CustomerTravelPackage ctp)
        {
            if(ctp == null)
            {
                return NotFound();
            }
            if(ModelState.IsValid)
            {
               await _ctpr.Update(ctp);
            }

            return RedirectToAction("CustomerDashBoard","Customer");
        }
    }
}