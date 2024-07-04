using DataAccess.Data;
using DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using Models;
using System.Diagnostics;

namespace SchoolManagementSystemDotnet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db, IWebHostEnvironment webHostEnvironment, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _webHostEnvironment = webHostEnvironment;
            _unitOfWork = unitOfWork;
        }
        // Dashboard
        public IActionResult Index()
        {
            IEnumerable<Student> studentsList = _unitOfWork.Student.GetAll();
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
                    _unitOfWork.Student.Add(student);
                    _unitOfWork.Save();
                    return RedirectToAction("Index");
                }
            }
            return View();
        }
        // Edit Employee
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0) return NotFound();
            var student = _unitOfWork.Student.FindById(id);
            if(student == null) return NotFound();
            return View(student);
        }
        [HttpPost]
        public IActionResult Edit(Student student, IFormFile? file)
        {
            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    if(student.ProfilePicture != null)
                    {
                        var oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, student.ProfilePicture.Trim('\\'));
                        if (System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);
                        }
                    }
                    // Get the root path
                    string wwwRootPath = _webHostEnvironment.WebRootPath;
                    // Rename the file
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    // Set path
                    string productPath = Path.Combine(wwwRootPath, @"Images/Students");
                    // Save image
                    using (var fileStream = new FileStream(Path.Combine(productPath, fileName), FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                    student.ProfilePicture = @"/Images/Students/" + fileName; 
                }
                _unitOfWork.Student.Update(student);
                _unitOfWork.Save();
                return RedirectToAction("Index");
            }
            return View(student);
        }
        // Remove Employee
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0) return NotFound();
            var student = _unitOfWork.Student.FindById(id);
            if (student == null) return NotFound();
            return View(student);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult Remove(Student student)
        {
            if (student.ProfilePicture != null)
            {
                var oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, student.ProfilePicture.Trim('\\'));
                if (System.IO.File.Exists(oldImagePath))
                {
                    System.IO.File.Delete(oldImagePath);
                }
            }
            _unitOfWork.Student.Remove(student);
            _unitOfWork.Save();
            return RedirectToAction("Index");
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
