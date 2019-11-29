using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Domain.Data;
using Domain.Data.MainRepository.Repositories;
using Library.Models.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace UI.Areas.Customer.Controllers
{
    [Authorize(Roles = "Customer")]
    [Area("Customer")]
    public class CustomerController : Controller
    {
        private readonly CustomerRepository _customerRepository;

        public CustomerController(CustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
 
        public async Task<IActionResult> CustomerDashBoard()
        {
            Person customer = await _customerRepository.GetCustomerByUserId(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var list = _customerRepository.GetAllOfCustomersTravelPackages(customer.Id);
            //IEnumerable<CustomerTravelPackage> IEList = list;
            return View(list);
        }

        [HttpGet]
        public IActionResult ConfirmPurchase(int id)
        {
          
            if(id == 0)
            {
                return NotFound();
            }
            var tp = _customerRepository.GetTP(id);
            return View(tp);
        }




        [HttpGet]
        public IActionResult Purchase(int id ,string paymentType)
        {
            if(paymentType == "bc")
            {
                ViewBag.PaymentType = "";
            }
            if(paymentType == "cc")
            {

            }
            if(paymentType == "pp")
            {

            }

            return View();
        }

        [HttpPost]
        public IActionResult Purchase()
        {
            return View();
        }


    }
}