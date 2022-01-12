using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.DTO
{
    public class Instructor
    {
       
        public int InstructorId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Course { get; set; }
        
    }
}
