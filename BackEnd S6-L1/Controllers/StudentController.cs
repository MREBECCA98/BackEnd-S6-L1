using BackEnd_S6_L1.Models.Entities;
using BackEnd_S6_L1.Services;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd_S6_L1.Controllers
{

    public class StudentController : Controller
    {
        private readonly StudentServices _studentServices;
        public StudentController(StudentServices studentServices)
        {
            _studentServices = studentServices;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var student = await _studentServices.GetAllStudents();

            return View(student);
        }

        [HttpPost]
        public async Task<IActionResult> Index(Student student)
        {
            if (!ModelState.IsValid)
            {
                return View(await _studentServices.GetAllStudents());

            }
            await _studentServices.CreateAsync(student);
            return RedirectToAction("Index");

        }

        public IActionResult CreateForm()
        {
            return PartialView("_createStudent");
        }

        public async Task<IActionResult> StudentsTable()
        {
            var students = await _studentServices.GetAllStudents();
            return PartialView("_StudentsTable", students);

        }
    }

}
