using DataAccess.Data;
using Microsoft.AspNetCore.Mvc;
using Models;
using System.Diagnostics;

namespace SchoolManagementSystemDotnet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db, IWebHostEnvironment webHostEnvironment)
        {
            _logger = logger;
            _db = db;
            _webHostEnvironment = webHostEnvironment;
        }
        // Dashboard
        public IActionResult Index()
        {
            IEnumerable<Student> studentsList = _db.Students.ToList();
            return View(studentsList);
        }
        // Create Employee
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student student, IFormFile? file)
        {
            if(ModelState.IsValid)
            {
                // Get the root path
                string wwwRootPath = _webHostEnvironment.WebRootPath;
                if(file != null)
                {
                    // Rename the file
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    // Set path
                    string productPath = Path.Combine(wwwRootPath, @"Images/Students");
                    // Save image
                    using(var fileStream = new FileStream(Path.Combine(productPath, fileName), FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                    student.ProfilePicture = @"/Images/Students/" + fileName;
                    _db.Students.Add(student);
                    _db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
