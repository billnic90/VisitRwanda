using Microsoft.AspNetCore.Mvc;
using VisitRwanda.Models;
using System.Linq;

namespace VisitRwanda.Controllers
{
    public class HomeController : Controller
    {
        private readonly VisitRwandaContext _context;
        public HomeController(VisitRwandaContext context)
            => _context = context;

        public IActionResult Index()
        {
            return View();
        }

        // GET /Home/Tourism
        public IActionResult Tourism()
        {
            var model = _context.Destinations
                                .OrderBy(d => d.Name)
                                .ToList();
            
            return View("~/Views/Destinations/Index.cshtml", model);
        }

        // GET /Home/Culture
        public IActionResult Culture()
        {
            var model = _context.Cultures
                                .OrderBy(c => c.Title)
                                .ToList();
            return View("~/Views/Cultures/Index.cshtml", model);
        }

        // GET /Home/Investment
        public IActionResult Investment()
        {
            var model = _context.Investments
                                .OrderBy(i => i.Sector)
                                .ToList();
            return View("~/Views/Investments/Index.cshtml", model);
        }
    }
}
