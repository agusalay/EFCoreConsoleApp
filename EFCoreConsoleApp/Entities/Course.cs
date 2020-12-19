using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreConsoleApp.Entities
{
    public class Course
    {
        public int CourseId { get; set; }

        public string CourseName { get; set; }

        public DateTime StartDate { get; set; }
        
        public DateTime EndDate { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
