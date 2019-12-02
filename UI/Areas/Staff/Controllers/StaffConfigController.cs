using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Data.MainRepository.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UI.Data;
using Microsoft.AspNetCore.Identity;
using Library.Models.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Domain.Data.DataTransferObjects;

namespace UI.Areas.Staff.Controllers
{
    [Area("Staff")]
    public class StaffConfigController : Controller
    {
        private readonly StaffRepository _sr;
        private readonly ApplicationDbContext _aDbContext;
      //  private readonly RoleManager<Employee> _rm;
        private readonly UserManager<IdentityUser> _um;
     

        public StaffConfigController(StaffRepository sr, ApplicationDbContext aDbContext,  UserManager<IdentityUser> um)
        {
            _sr = sr;
            _aDbContext= aDbContext;
           // _rm = rm;
            _um = um;
        
        }


        [HttpGet]
        public async  Task<IActionResult> Index()
        {
            var staff = await _um.GetUsersInRoleAsync("Administrator");
            return View(staff);
        }

        //Create the create view
        [HttpGet]
        public async Task<IActionResult> ConfigureNewStaff()
        {
            var list = await _um.GetUsersInRoleAsync("Customer");


            ViewData["staffList"] = new SelectList(list,"Id","UserName" );
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ConfigureNewStaff(DTOUserRole dTOUserRole)
        {
            var user = _um.Users.FirstOrDefault(user => user.Id == dTOUserRole.UserId);
            await _um.AddToRoleAsync(user, "Administrator");
            return RedirectToAction("Index");



        }




    }
}