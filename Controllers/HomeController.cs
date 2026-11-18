using Microsoft.AspNetCore.Mvc;
using PhamBaTuanTu_241230880_2.Models;
using System.Diagnostics;

namespace PhamBaTuanTu_241230880_2.Controllers
{
    public class HomeController : Controller
    {
        private readonly QlnhaSachContext _context;
        public HomeController(QlnhaSachContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var danhSach = _context.Saches.Where(s => s.Gia >= 100).ToList();
            ViewData["TieuDe"] = "Pham Ba Tuan Tu";
            return View(danhSach);
        }
        
    }
}
