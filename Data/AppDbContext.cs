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

        public DbSet<DoctorModel> Doctors { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
    }
}