using System;

namespace EFProject.Entities
{
    public class Course_Student
    {
        // ========== Foreign Keys ==========
        public int StudentID { get; set; }
        public int CourseID { get; set; }

        // ========== Navigation Properties ==========

        // Each Course_Student belongs to one Student
        public Student? Student { get; set; }

        // Each Course_Student belongs to one Course
        public Course? Course { get; set; }
    }
}
