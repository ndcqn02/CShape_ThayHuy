using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity110.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title110 { get; set; }
        public int Credits110 { get; set; }

        public ICollection<Enrollment> Enrollments110 { get; set; }
    }
}
