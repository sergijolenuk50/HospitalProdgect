using Microsoft.AspNetCore.Mvc;
using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class DoctorsController : Controller
    {
       // static List<Doctor>  doctor;
            private HospitalDbContext ctx = new HospitalDbContext();
        public DoctorsController() {

            //doctor = new List<Doctor>() {
            //    new Doctor() {Id = 1, FirstName ="Grec", Name = "Stepan", LastName = "Ivanivuch" , Birthday = new DateTime(1985,05,01), Categori = "LOR", Work_experience =5},
            //    new Doctor() {Id = 1, FirstName ="Ivanov", Name = "Stanislav", LastName = "Ivanivuch" , Birthday = new DateTime(1988,11,12), Categori = "TERAPEVT", Work_experience =6},
            //    new Doctor() {Id = 1, FirstName ="Sidorov", Name = "Sergii", LastName = "Romanovich" , Birthday = new DateTime(1981,06,25), Categori = "SURGEON", Work_experience =10},
            //    };
        }
        public IActionResult Index()
        {
        var doctor = ctx.Doctors.ToList();
            return View(doctor);
        }
        //public IActionResult Index()
        //{
        //    return View(doctor);
        //}
    }
}
