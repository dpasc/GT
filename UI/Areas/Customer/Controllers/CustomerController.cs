﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Data;
using Domain.Data.MainRepository.Repositories;
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
 
        public IActionResult Index()
        {
            return View();
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