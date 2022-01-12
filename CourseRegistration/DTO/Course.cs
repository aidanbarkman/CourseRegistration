using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.DTO
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseNumber { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }

    }
}
