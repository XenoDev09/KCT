using KCT.Interfaces;
using KCT.Models;

namespace KCT.Services
{
    public class StudentService : IStudentService
    {
        public StudentViewModel GetInfo()
        {
            StudentViewModel student = new StudentViewModel();
            student.Id = 1;
            student.FullName = "Nischal Moktan";
            student.Email = "nischal123321@gmail.com";
            return student;
        }
        
    }
}
