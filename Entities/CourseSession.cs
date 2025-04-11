using System;

namespace EFProject.Entities
{
    public class CourseSession
    {
        // ========== Primary Properties ==========
        public int ID { get; set; }
        public DateTime? Date { get; set; }
        public string Title { get; set; } = string.Empty;

        // ========== Foreign Keys ==========
        public int InstructorID { get; set; }
        public int CourseID { get; set; }

        // ========== Navigation Properties ==========

        // Each CourseSession belongs to one Instructor
        public Instructor? Instructor { get; set; }

        // Each CourseSession belongs to one Course
        public Course? Course { get; set; }
    }
}
