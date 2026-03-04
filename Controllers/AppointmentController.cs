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
        [ValidateAntiForgeryToken]
        public IActionResult Add(Appointment appointment)
        {
            // ❌ Không cho đặt ngày trong quá khứ
            if (appointment.AppointmentDate.Date < DateTime.Today)
            {
                ModelState.AddModelError("AppointmentDate",
                    "Không được đặt lịch với ngày trong quá khứ!");
            }

            if (ModelState.IsValid)
            {
                // ❌ Kiểm tra trùng lịch bác sĩ
                bool isDuplicate = _context.Appointments.Any(a =>
                    a.DoctorId == appointment.DoctorId &&
                    a.AppointmentDate.Date == appointment.AppointmentDate.Date &&
                    a.AppointmentTime == appointment.AppointmentTime
                );

                if (isDuplicate)
                {
                    ModelState.AddModelError("",
                        "Bác sĩ đã có lịch trong ngày và giờ này!");
                }
                else
                {
                    _context.Appointments.Add(appointment);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
            }

            ViewBag.Doctors = _context.Doctors.ToList();
            return View(appointment);
        }

        // ================= SỬA (GET) =================
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

        // ================= SỬA (POST) =================
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Appointment model)
        {
            // ❌ Không cho sửa về ngày quá khứ
            if (model.AppointmentDate.Date < DateTime.Today)
            {
                ModelState.AddModelError("AppointmentDate",
                    "Không được đặt lịch với ngày trong quá khứ!");
            }

            if (ModelState.IsValid)
            {
                // ❌ Kiểm tra trùng (trừ chính nó)
                bool isDuplicate = _context.Appointments.Any(a =>
                    a.Id != model.Id &&
                    a.DoctorId == model.DoctorId &&
                    a.AppointmentDate.Date == model.AppointmentDate.Date &&
                    a.AppointmentTime == model.AppointmentTime
                );

                if (isDuplicate)
                {
                    ModelState.AddModelError("",
                        "Bác sĩ đã có lịch trong ngày và giờ này!");
                }
                else
                {
                    _context.Appointments.Update(model);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
            }

            ViewBag.Doctors = _context.Doctors.ToList();
            return View(model);
        }

        // ================= XÓA (GET) =================
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

        // ================= XÓA (POST) =================
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