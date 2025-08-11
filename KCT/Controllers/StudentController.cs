using KCT.Interfaces;
using KCT.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace KCT.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository _studentRepository;

        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        // GET: Student
        public async Task<IActionResult> Index()
        {
            var students = await _studentRepository.GetAllAsync();
            return View(students);
        }

        // GET: Student/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var student = await _studentRepository.GetByIdAsync(id);
            if (student == null)
                return NotFound();

            return View(student);
        }

        // GET: Student/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Student student)
        {
            if (ModelState.IsValid)
            {
                await _studentRepository.AddAsync(student);
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        // GET: Student/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var student = await _studentRepository.GetByIdAsync(id);
            if (student == null)
                return NotFound();

            return View(student);
        }

        // POST: Student/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Student student)
        {
            if (id != student.Id)
                return BadRequest();

            if (ModelState.IsValid)
            {
                await _studentRepository.UpdateAsync(student);
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        // GET: Student/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var student = await _studentRepository.GetByIdAsync(id);
            if (student == null)
                return NotFound();

            return View(student);
        }

        // POST: Student/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _studentRepository.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
