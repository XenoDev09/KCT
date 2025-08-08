using KCT.Models;
using KCT.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace KCT.Controllers
{
    public class DStudentController : Controller
    {
        private readonly DStudentService _dStudentService;

        public DStudentController(DStudentService dStudentService)
        {
            _dStudentService = dStudentService;
        }

        // Display all students
        public async Task<IActionResult> Index()
        {
            var students = await _dStudentService.GetAllStudents();
            return View(students); // Pass to Index.cshtml
        }

        // Show form to create a new student
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // Handle form submission
        [HttpPost]
        public async Task<IActionResult> Create(StudentViewModel student)
        {
            if (ModelState.IsValid)
            {
                await _dStudentService.AddStudent(student);
                return RedirectToAction("Index");
            }
            return View(student);
        }
    }
}
