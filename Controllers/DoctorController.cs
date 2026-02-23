using Microsoft.AspNetCore.Mvc;

namespace WebDatLichKham.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
