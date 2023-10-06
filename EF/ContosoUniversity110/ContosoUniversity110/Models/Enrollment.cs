using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity110.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? Grade110 { get; set; }

        public Course Course110 { get; set; }
        public Student Student110 { get; set; }
    }
}
