using SchoolProject.Models;
using System.Linq;
namespace SchoolProject.Repository { 
	public interface ITeacherRepository
	{
		public List<Teacher> GetAllTeachers();
		public void Create(Teacher teacher);
		public void Delete(int id);
	}
}
