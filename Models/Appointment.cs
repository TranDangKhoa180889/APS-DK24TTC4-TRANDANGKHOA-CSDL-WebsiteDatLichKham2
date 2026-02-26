using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatLichKham.Models
{
    public class Appointment
    {
        public int Id { get; set; }

        public string? PatientName { get; set; }

        public DateTime AppointmentDate { get; set; }

        public string? AppointmentTime { get; set; }   // PHẢI có dòng này

        public int DoctorId { get; set; }

        public DoctorModel? Doctor { get; set; }
    }
}