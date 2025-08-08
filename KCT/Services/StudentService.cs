using KCT.Interfaces;
using KCT.Models;

namespace KCT.Services
{
    public class StudentService : IStudentService
    {
        public StudentViewModel GetInfo()
        {
            StudentViewModel student = new StudentViewModel();
            student.Name = "Nischal";
            student.Id = 1;
            student.Description = " Hey, My name is Nischal Moktan";
            return student;
        }
        
    }
}
