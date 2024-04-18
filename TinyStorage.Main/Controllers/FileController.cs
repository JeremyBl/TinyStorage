using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TinyStorage.Main.Models;

namespace TinyStorage.Main.Controllers
{
    public class FileController : Controller
    {
        private readonly ILogger<FileController> _logger;

        public FileController(ILogger<FileController> logger)
        {
            _logger = logger;
        }

        public IActionResult File()
        {
            return View("~/Views/File/File.cshtml");
        }
    }
}
