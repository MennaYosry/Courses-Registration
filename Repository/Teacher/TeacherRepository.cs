using SchoolProject.context;
using SchoolProject.Models;

namespace SchoolProject.Repository
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly MyDBContext _myDbContext;
        public TeacherRepository(MyDBContext myDbContext) {
            _myDbContext = myDbContext;
        }

        public void Create(Teacher teacher)
        {
            _myDbContext.Teachers.Add(teacher);
            _myDbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            Teacher teacher = (from teacherObj in _myDbContext.Teachers
                               where teacherObj.TeacherId==id
                               select teacherObj).FirstOrDefault();
            _myDbContext.Teachers.Remove(teacher);
            _myDbContext.SaveChanges();
        }

        public List<Teacher> GetAllTeachers()
        {
           List<Teacher> teachers = (from teacherObj in _myDbContext.Teachers
                                     select teacherObj).ToList();
            return teachers;
        }
    }
}