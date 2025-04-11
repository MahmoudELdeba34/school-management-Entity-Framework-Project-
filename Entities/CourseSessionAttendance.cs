using System;

namespace EFProject.Entities
{
    public class CourseSessionAttendance
    {
        // ========== Primary Properties ==========
        public int ID { get; set; }
        public int Grade { get; set; }
        public string? Notes { get; set; }

        // ========== Foreign Keys ==========
        public int StudentID { get; set; }
        public int CourseSessionID { get; set; }

        // ========== Navigation Properties ==========

        // Each CourseSessionAttendance belongs to one Student
        public Student? Student { get; set; }

        // Each CourseSessionAttendance belongs to one CourseSession
        public CourseSession? CourseSession { get; set; }
    }
}
