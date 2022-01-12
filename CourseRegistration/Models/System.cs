using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Models
{
    public class System
    {
    }
    public interface IregistrationRepo
    {
        IEnumerable<StudentViewModel> GetStudentViewModels(StudentViewModel svm);
        StudentViewModel GetStudent(String StudentID);

    }
}
