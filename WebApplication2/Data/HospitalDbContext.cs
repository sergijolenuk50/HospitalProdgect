using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class HospitalDbContext : DbContext
    {
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string str = "Data Source=(localdb)\\ProjectModels;Initial Catalog=Hospital_Olenuk;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            //optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ShopMvc_PV212;Integrated Security=True;");
            optionsBuilder.UseSqlServer(str);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Doctor>().HasData(new List<Doctor>()
            {
            new Doctor() {Id = 1, FirstName ="Grec", Name = "Stepan", LastName = "Ivanivuch" , Birthday = new DateTime(1985,05,01), Categori = "LOR", Work_experience =5},
            new Doctor() {Id = 2, FirstName ="Ivanov", Name = "Stanislav", LastName = "Ivanivuch" , Birthday = new DateTime(1988,11,12), Categori = "TERAPEVT", Work_experience =6},
            new Doctor() {Id = 3, FirstName ="Sidorov", Name = "Sergii", LastName = "Romanovich" , Birthday = new DateTime(1981,06,25), Categori = "SURGEON", Work_experience =10},
            });
        }

        public DbSet<Doctor> Doctors { get; set; }
    }
    
}
