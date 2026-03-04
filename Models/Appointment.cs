using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebDatLichKham.Models
{
    [Index(nameof(DoctorId), nameof(AppointmentDate), nameof(AppointmentTime), IsUnique = true)]
    public class Appointment
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Bệnh nhân")]
        public string PatientName { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Ngày khám")]
        [DataType(DataType.Date)]
        public DateTime AppointmentDate { get; set; }

        [Required]
        [Display(Name = "Giờ khám")]
        public string AppointmentTime { get; set; } = string.Empty;

        // KHÓA NGOẠI
        [Required]
        [Display(Name = "Bác sĩ")]
        public int DoctorId { get; set; }

        // NAVIGATION PROPERTY
        [ForeignKey("DoctorId")]
        public DoctorModel? Doctor { get; set; }
    }
}