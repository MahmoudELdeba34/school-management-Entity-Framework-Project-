using System;
using System.Collections.Generic;

namespace EFProject.Entities
{
    public class Instructor
    {
        // ========== Primary Properties ==========
        public int ID { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;

        // ========== Foreign Keys ==========
        public int DepartmentID { get; set; }

        // ========== Navigation Properties ==========

        // The department to which the instructor belongs
        public Department? Department { get; set; }

        // The department this instructor manages (if any)
        public Department? ManagedDepartment { get; set; }

        // Courses taught by this instructor
        public List<Course> Courses { get; set; } = new();

        // Sessions led by this instructor
        public List<CourseSession> CourseSessions { get; set; } = new();
    }
}
