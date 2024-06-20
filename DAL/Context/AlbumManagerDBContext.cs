using Microsoft.EntityFrameworkCore;
using MODELS.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    public class AlbumManagerDBContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<AlbumManager> AlbumManagers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data source=MAHMUT_TAYLAN\\SQLEXPRESS;Initial catalog=AlbumYoneticiMahmutTaylan;Integrated security=true; trustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(System.Reflection.Assembly.GetExecutingAssembly());
        }

    }
}
