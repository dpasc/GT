
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;
using Domain.Data.MainRepository.Repositories;
using Library.Models.Models;
using System.Security.Claims;

namespace UI.Areas.Staff.Controllers
{

    [Authorize(Roles = "Administrator")]
    [Area("Staff")]
    public class StaffController : Controller
    {

        private readonly StaffRepository _staffRepository;

        public StaffController(StaffRepository sr)
        {
            _staffRepository = sr;
        }

        [HttpGet]
        public  IActionResult StaffDashboard()
        {
            return View();
        }






    }
}