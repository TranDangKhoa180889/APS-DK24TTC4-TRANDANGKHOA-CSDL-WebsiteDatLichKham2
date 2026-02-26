using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebDatLichKham.Data;
using WebDatLichKham.Models;

namespace WebDatLichKham.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly AppDbContext _context;

        public AppointmentController(AppDbContext context)
        {
            _context = context;
        }

        // ==========================
        // DANH SÁCH
        // ==========================
        public IActionResult Index()
        {
            var data = _context.Appointments
                               .Include(a => a.Doctor)
                               .ToList();

            return View(data);
        }

        // ==========================
        // THÊM (GET)
        // ==========================
        public IActionResult Add()
        {
            ViewBag.Doctors = _context.Doctors.ToList();
            return View();
        }

        // ==========================
        // THÊM (POST)
        // ==========================
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Appointment appointment)
        {
            if (ModelState.IsValid)
            {
                _context.Appointments.Add(appointment);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Doctors = _context.Doctors.ToList();
            return View(appointment);
        }

        // ==========================
        // SỬA (GET)
        // ==========================
        public IActionResult Edit(int id)
        {
            var item = _context.Appointments.Find(id);
            if (item == null) return NotFound();

            ViewBag.Doctors = _context.Doctors.ToList();
            return View(item);
        }

        // ==========================
        // SỬA (POST)
        // ==========================
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Appointment appointment)
        {
            if (ModelState.IsValid)
            {
                _context.Appointments.Update(appointment);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Doctors = _context.Doctors.ToList();
            return View(appointment);
        }

        // ==========================
        // XOÁ (GET)
        // ==========================
        public IActionResult Delete(int id)
        {
            var item = _context.Appointments
                               .Include(a => a.Doctor)
                               .FirstOrDefault(a => a.Id == id);

            if (item == null) return NotFound();

            return View(item);
        }

        // ==========================
        // XOÁ (POST)
        // ==========================
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var item = _context.Appointments.Find(id);
            if (item != null)
            {
                _context.Appointments.Remove(item);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}