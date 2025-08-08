using KCT.Models;
using KCT.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace KCT.Controllers
{
    public class StudentsController : Controller
    {
        private readonly DStudentService _studentService;

        public StudentsController(DStudentService studentService)
        {
            _studentService = studentService;
        }

        // GET: /Students
        public async Task<IActionResult> Index()
        {
            var students = await _studentService.GetAllStudents();
            return View(students);
        }

        // GET: /Students/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Students/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(StudentViewModel student)
        {
            if (ModelState.IsValid)
            {
                await _studentService.AddStudent(student);
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }
    }
}
