using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Jenkins10.Models;
using Jenkins10.Data;
using Microsoft.EntityFrameworkCore;

namespace Jenkins10.Controllers
{
    public class CoursesController : Controller
    {
        private readonly SchoolContext _context;
        public CoursesController(SchoolContext context)
        {
            _context = context;
        }
     /*   public async Task<IActionResult> Index()
        {
            var courses = await _context.Courses.ToListAsync();
            return View(courses);
        }
     */
        public async Task<IActionResult> Index()
        {
            var courses = await getAllCourses(); // Await the asynchronous method
            return View(courses);
        }
        public async Task<List<Jenkins10.Models.Course>> getAllCourses()
        {
            var courses = await _context.Courses.ToListAsync();
            return courses;
        }
    }
}
