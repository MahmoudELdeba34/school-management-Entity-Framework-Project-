using System;
using System.Collections.Generic;

namespace EFProject.Entities
{
    public class Department
    {
        // ========== Primary Properties ==========
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;

        // ========== Foreign Keys ==========
        public int? ManagerID { get; set; }

        // ========== Navigation Properties ==========

        // Each Department is managed by one Instructor (Manager)
        public Instructor? Manager { get; set; }

        // Each Department has many Courses
        public List<Course> Courses { get; set; } = new();

        // Each Department has many Instructors
        public List<Instructor> Instructors { get; set; } = new();
    }
}
