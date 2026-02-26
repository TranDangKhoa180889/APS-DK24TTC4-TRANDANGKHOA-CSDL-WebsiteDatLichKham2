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

        // ================= DANH SÁCH =================
        public IActionResult Index()
        {
            var list = _context.Appointments
                               .Include(a => a.Doctor)
                               .ToList();
            return View(list);
                }

        // ================= THÊM (GET) =================
        public IActionResult Add()
        {
            ViewBag.Doctors = _context.Doctors.ToList();
            return View();
        }

        // ================= THÊM (POST) =================
        [HttpPost]
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

        // ================= SỬA =================
        // GET: Edit
        public IActionResult Edit(int id)
        {
            var appointment = _context.Appointments.Find(id);

            if (appointment == null)
            {
                return NotFound();
            }

            ViewBag.Doctors = _context.Doctors.ToList();
            return View(appointment);
        }


        // POST: Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Appointment model)
        {
            if (ModelState.IsValid)
            {
                _context.Appointments.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Doctors = _context.Doctors.ToList();
            return View(model);
        }

        // ================= XÓA =================
        // GET: Delete
        public IActionResult Delete(int id)
        {
            var appointment = _context.Appointments
                .Include(a => a.Doctor)
                .FirstOrDefault(a => a.Id == id);

            if (appointment == null)
            {
                return NotFound();
            }

            return View(appointment);
        }


        // POST: Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var appointment = _context.Appointments.Find(id);

            if (appointment != null)
            {
                _context.Appointments.Remove(appointment);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}