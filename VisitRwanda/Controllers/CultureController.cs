using Microsoft.AspNetCore.Mvc;
using VisitRwanda.Models;

namespace VisitRwanda.Controllers
{
    public class CulturesController : Controller
    {
        private readonly VisitRwandaContext _context;

        public CulturesController(VisitRwandaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var cultures = _context.Cultures
                .OrderBy(c => c.Title)
                .ToList();

            return View(cultures);
        }
    }
}
