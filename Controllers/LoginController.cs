using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace WebDatLichKham.Controllers
{
    public class LoginController : Controller
    {
        // HIỂN THỊ FORM LOGIN
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // XỬ LÝ LOGIN
        [HttpPost]
        public IActionResult Index(string username, string password)
        {
            if (username == "admin" && password == "123")
            {
                HttpContext.Session.SetString("username", username);
                return RedirectToAction("Index", "Home");
            }

            ViewBag.Error = "Sai tài khoản hoặc mật khẩu";
            return View();
        }

        // LOGOUT
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Login");
        }
    }
}
