using Microsoft.AspNetCore.Mvc;
using WebDatLichKham.Models;
using System.Collections.Generic;
using System.Linq;

namespace WebDatLichKham.Controllers
{
    public class AppointmentController : Controller
    {
        private static List<AppointmentModel> appointments = new List<AppointmentModel>();

        // ========================
        // DANH SÁCH
        // ========================
        public IActionResult Index()
        {
            return View(appointments);
        }

        // ========================
        // ADD - GET
        // ========================
        public IActionResult Add()
        {
            return View();
        }

        // ========================
        // ADD - POST
        // ========================
        [HttpPost]
        public IActionResult Add(AppointmentModel model)
        {
            model.Id = appointments.Count + 1;
            appointments.Add(model);
            return RedirectToAction("Index");
        }

        // ========================
        // EDIT - GET
        // ========================
        public IActionResult Edit(int id)
        {
            var data = appointments.FirstOrDefault(x => x.Id == id);
            return View(data);
        }

        // ========================
        // EDIT - POST
        // ========================
        [HttpPost]
        public IActionResult Edit(AppointmentModel model)
        {
            var data = appointments.FirstOrDefault(x => x.Id == model.Id);

            if (data != null)
            {
                data.DoctorId = model.DoctorId;
                data.FullName = model.FullName;
                data.Specialty = model.Specialty;
                data.Phone = model.Phone;
                data.TrangThai = model.TrangThai;
            }

            return RedirectToAction("Index");
        }
    }
}

