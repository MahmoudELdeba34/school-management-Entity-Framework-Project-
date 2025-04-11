using System.Collections.Generic;

namespace EFProject.Entities
{
    public class Course
    {
        // ========== Primary Properties ==========
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Duration { get; set; }

        // ========== Foreign Keys ==========
        public int DepartmentID { get; set; }
        public int InstructorID { get; set; }

        // ========== Navigation Properties ==========

        // Department Relation: Each Course belongs to One Department
        public Department? Department { get; set; }

        // Instructor Relation: Each Course belongs to One Instructor
        public Instructor? Instructor { get; set; }

        // Course_Student Relation: Each Course has many Course_Student records
        public ICollection<Course_Student> Courses_Students { get; set; }

        // CourseSession Relation: Each Course has many Sessions
        public ICollection<CourseSession> CoursesSessions { get; set; }

        // ========== Constructor ==========
        public Course()
        {
            Courses_Students = new HashSet<Course_Student>();
            CoursesSessions = new HashSet<CourseSession>();
        }
    }
}
