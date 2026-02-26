using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDatLichKham.Models
{
    [Table("Doctors")]
    public class DoctorModel
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }   // PHẢI có dòng này

        [Required]
        public string? DoctorName { get; set; }
        [Required]
        public string? Specialty { get; set; }

        [Required]
        public string? Phone { get; set; }
    }
}