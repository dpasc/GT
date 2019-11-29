
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;
using Domain.Data.MainRepository.Repositories;
using Library.Models.Models;
using System.Security.Claims;

namespace UI.Areas.Staff.Controllers
{

    //[Authorize(Roles = "Administrator")]
    [Area("Staff")]
    public class StaffController : Controller
    {

        private readonly StaffRepository _staffRepository;

        public StaffController(StaffRepository sr)
        {
            _staffRepository = sr;
        }


        public async Task<IActionResult> Index()
        {
            Employee staff = await _staffRepository.GetEmployeeByUserId(User.FindFirstValue(ClaimTypes.NameIdentifier));

            ViewBag.StaffMember = staff;
            //Get all travel packages
            var list = _staffRepository.GetAllTravelPackages();
            return View(list);
        }

        [HttpGet]
        public async Task<IActionResult> UpdateDetails(string id)
        {
            if(id == null)
            {

                return NotFound();
            }
            var staff = await _staffRepository.GetEmployeeByUserId(id);
            if(staff == null)
            {
                return NotFound();
            }

            return View(staff);
        }


     
    }
}