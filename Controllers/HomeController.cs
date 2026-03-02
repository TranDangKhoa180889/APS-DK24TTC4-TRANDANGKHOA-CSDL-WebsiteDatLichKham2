using Microsoft.AspNetCore.Mvc;

namespace WebDatLichKham.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Kiểm tra đăng nhập
            var username = HttpContext.Session.GetString("Username");
            if (string.IsNullOrEmpty(username))
            {
                return RedirectToAction("Index", "Login");
            }

            ViewBag.Username = username;
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
    }

}
