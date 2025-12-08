using Microsoft.AspNetCore.Mvc;
using VisitRwanda.Models;
using Microsoft.EntityFrameworkCore;

namespace VisitRwanda.Controllers
{
    public class DestinationsController : Controller
    {
        private readonly VisitRwandaContext _context;

        public DestinationsController(VisitRwandaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var destinations = _context.Destinations
                .OrderBy(d => d.Name)
                .ToList();

            return View(destinations);
        }
    }
}
