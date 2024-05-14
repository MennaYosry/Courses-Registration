using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolProject.Models
{
    public class StudentCourse
    {
        [Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentCourseId { get; set; }
        public int StudentId { get; set; }
        public Student student { get; set; }
        public int CourseId {  get; set; }
        public Course course { get; set; }

    }
}
