using Microsoft.AspNetCore.Mvc;
using SchoolProject.Models;
using SchoolProject.Repository;

namespace SchoolProject.Controllers
{
    public class TeacherController : Controller { 

        private readonly ITeacherRepository _teacherRepository;
        public TeacherController(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        [HttpGet]
        public ActionResult Index()
        {
            List<Teacher> teachers = _teacherRepository.GetAllTeachers();
            return View(teachers);
        }
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Teacher teacher) 
        {
            if (teacher != null)
            {
                _teacherRepository.Create(teacher);
            }
            List<Teacher> teachers = _teacherRepository.GetAllTeachers();
            return RedirectToAction("Index",teachers);
        }
        public ActionResult Delete(int id)
        {
            _teacherRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
