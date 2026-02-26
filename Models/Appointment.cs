using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatLichKham.Models
{
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
        [Display(Name = "Bác sĩ")]
        public int DoctorId { get; set; }

        // NAVIGATION
        public DoctorModel? Doctor { get; set; }
    }
}