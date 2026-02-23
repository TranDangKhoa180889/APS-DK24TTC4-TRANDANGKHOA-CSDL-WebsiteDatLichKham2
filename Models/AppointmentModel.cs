namespace WebDatLichKham.Models
{
    public class AppointmentModel
    {
        public int Id { get; set; }   // THÊM DÒNG NÀY

        public int DoctorId { get; set; }

        public string FullName { get; set; }

        public string Specialty { get; set; }

        public string Phone { get; set; }

        public string TrangThai { get; set; }
    }
}

