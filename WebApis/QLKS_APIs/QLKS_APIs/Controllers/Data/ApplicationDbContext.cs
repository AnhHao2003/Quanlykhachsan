using Microsoft.EntityFrameworkCore;
using QLKS_APIs.Controllers.Models;

namespace QLKS_APIs.Controllers.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; } // Corrected property name and accessor

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); // Corrected base call
        }
        public DbSet<QLKS_APIs.Controllers.Models.DatPhong> DatPhong { get; set; } = default!;
        public DbSet<QLKS_APIs.Controllers.Models.KhachHang> KhachHang { get; set; } = default!;
        public DbSet<QLKS_APIs.Controllers.Models.Phong> Phong { get; set; } = default!;
        public DbSet<QLKS_APIs.Controllers.Models.ThanhToan> ThanhToan { get; set; } = default!;
        public DbSet<QLKS_APIs.Controllers.Models.Khachsan> Khachsan { get; set; } = default!;
    }
}
