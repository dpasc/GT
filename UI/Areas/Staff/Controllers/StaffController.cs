
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace UI.Areas.Staff.Controllers
{
    [Authorize(Roles = "Administrator")]
    [Area("Staff")]
    public class StaffController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}