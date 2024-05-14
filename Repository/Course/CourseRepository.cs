using SchoolProject.context;
using SchoolProject.Models;

namespace SchoolProject.Repository
{
    public class CourseRepository: ICourseRepository
    {
        private readonly MyDBContext _myDbContext;
        public CourseRepository(MyDBContext myDbContext)
        {
            _myDbContext = myDbContext;
        }

        public void Create(Course course)
        {
            _myDbContext.Courses.Add(course);
            _myDbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            Course course = (from courseObj in _myDbContext.Courses
                               where courseObj.CourseId == id
                               select courseObj).FirstOrDefault();
            _myDbContext.Courses.Remove(course);
            _myDbContext.SaveChanges();
        }

        public List<Course> GetAllCourses()
        {
            List<Course> courses = (from courseObj in _myDbContext.Courses
                                      select courseObj).ToList();
            return courses;
        }

       
    }
}

