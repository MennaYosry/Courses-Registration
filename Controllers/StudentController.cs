using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolProject.Models;
using SchoolProject.Models.ViewModels;
using SchoolProject.Repository;

namespace SchoolProject.Controllers
{
    public class StudentController : Controller
    {
        private readonly Repository.IStudentRepository _studentRepository;
        private readonly Repository.ICourseRepository _courseRepository;
        public StudentController(IStudentRepository studentRepository , ICourseRepository courseRepository)
        {
            _studentRepository = studentRepository;
            _courseRepository = courseRepository;
        }

        // GET: StudentController
        //list of students
        public ActionResult Index()
        {
            List<Student> stdlst = _studentRepository.GetAllStudents();
            return View(stdlst);
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student student)
        {
            _studentRepository.Create(student);
            List<Student> stdlst = _studentRepository.GetAllStudents();
            return RedirectToAction("Index", stdlst);
        }


        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            _studentRepository.Delete(id);
            List<Student> stdlst = _studentRepository.GetAllStudents();
            return RedirectToAction("Index", stdlst);
        }
        [HttpGet]
        public ActionResult Register()
        {
            StudentCourseVM data = new StudentCourseVM();
            data.courses =_courseRepository.GetAllCourses();
            data.students = _studentRepository.GetAllStudents();
            return View(data);
        }
        [HttpPost]
        public ActionResult Register(int studentId, int courseId)
        {
            _studentRepository.Register(studentId, courseId);

            return RedirectToAction("Register");
        }

    }
}