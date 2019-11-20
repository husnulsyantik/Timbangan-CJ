using Microsoft.EntityFrameworkCore;

namespace CJTimbangan.Models
{
    public class SettingTimbanganContext : DbContext
    {
        public SettingTimbanganContext(DbContextOptions<SettingTimbanganContext> options) :base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Setting>().HasKey(e => new { e.id});
            modelBuilder.Entity<Input>().HasKey(a => new { a.id_transaksi});
        }

        public virtual DbSet<Setting> m_code { get; set; }
        public virtual DbSet<Input> m_hasil { get; set; }
        
    }
}