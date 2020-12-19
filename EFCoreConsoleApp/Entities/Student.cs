using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreConsoleApp.Entities
{
    public class Student
    {
        public int StudentId { get; set; }

        public string Name { get; set; }

        public int? CourseId { get; set; }

        public Course Course { get; set; }

    }
}
