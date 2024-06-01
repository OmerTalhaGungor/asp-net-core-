using Microsoft.EntityFrameworkCore;

namespace webodev3.Models {
    public class AdminContext : DbContext {
        public AdminContext() { }
        public AdminContext(DbContextOptions<AdminContext> options) : base (options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-UQ21GR2\\SQLEXPRESS;Initial Catalog=BilgisayarDB;Integrated Security=True;Trusted_Connection=True;Encrypt=False;");
        }

        public DbSet<Kayit> Kayitlar { get; set; }
    }
}