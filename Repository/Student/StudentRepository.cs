using SchoolProject.context;
using SchoolProject.Models;

namespace SchoolProject.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly MyDBContext _myDbConnection;
        public StudentRepository(MyDBContext myDbContext)
        {
            _myDbConnection = myDbContext;
        }

        public List<Student> GetAllStudents()
        {
            try
            {
                List<Student> students = (from stdsObj in _myDbConnection.Students
                                          select stdsObj).ToList();
                return students;
            }
            catch (Exception ex)
            {
               
                return null;
            }

        }
        public void Create(Student student)
        {
            _myDbConnection.Students.Add(student);
            
            _myDbConnection.SaveChanges();
        }

        public void Delete(int id)
        {
            Student student = (from stdObj in _myDbConnection.Students
                               where stdObj.StudentId==id
                               select stdObj).FirstOrDefault();
            _myDbConnection.Students.Remove(student);
            _myDbConnection.SaveChanges();
        }

        public void Register(int StudentId, int CourseId)
        {
            StudentCourse studentCourse = new StudentCourse();
            studentCourse.CourseId = CourseId;
            studentCourse.StudentId = StudentId;
            _myDbConnection.StudentCourses.Add(studentCourse);
            _myDbConnection.SaveChanges();
        }
    }
}
