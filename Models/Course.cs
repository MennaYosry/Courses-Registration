using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolProject.Models
{
    public class Course
    {
        [Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseId { get; set; }
        [MinLength(2)] 
        public string CourseName { get; set; }
        public int TeacherId {  get; set; }
        public Teacher teacher { get; set; }
        [Range(0, 30)] public int CourseCapacity { get; set; }

    }
}
