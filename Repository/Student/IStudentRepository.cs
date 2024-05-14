using System.Linq;
using SchoolProject.Models;
namespace SchoolProject.Repository
{
    public interface IStudentRepository
    {
        public List<Student> GetAllStudents();
        public void Create(Student student);
        public void Delete(int id);
        public void Register(int StudentId, int CourseId);
    }
}
