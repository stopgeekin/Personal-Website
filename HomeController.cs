using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace Extra_Credit.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Hobbies()
        {
            return View();
        }

        public IActionResult GetResume()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "files", "resume.pdf");

            if (!System.IO.File.Exists(filePath))
            {
                return NotFound("Resume file not found. Please upload it to wwwroot/files/resume.pdf");
            }

            // Serve as download
            return PhysicalFile(filePath, "application/pdf", "resume.pdf");
        }
    }
}
