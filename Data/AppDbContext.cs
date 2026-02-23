using Microsoft.EntityFrameworkCore;
using WebDatLichKham.Models;

namespace WebDatLichKham.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<AppointmentModel> Appointments { get; set; }
        public DbSet<DoctorModel> Doctors { get; set; }
    }
}