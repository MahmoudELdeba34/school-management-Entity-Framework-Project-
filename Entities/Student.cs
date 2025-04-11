using System;
using System.Collections.Generic;

namespace EFProject.Entities
{
    public class Student
    {
        // ========== Primary Properties ==========
        public int ID { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;

        // ========== Navigation Properties ==========

        // The attendances of the student in course sessions
        public List<CourseSessionAttendance> CourseSessionAttendances { get; set; } = new();

        // The courses the student is enrolled in
        public List<Course_Student> CourseStudents { get; set; } = new();
    }
}
