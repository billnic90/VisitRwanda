using Microsoft.AspNetCore.Mvc;
using VisitRwanda.Models;

namespace VisitRwanda.Controllers
{
    public class InvestmentsController : Controller
    {
        private readonly VisitRwandaContext _context;
        public InvestmentsController(VisitRwandaContext context)
            => _context = context;

        public IActionResult Index()
        {
            var opportunities = _context.Investments
                .OrderBy(i => i.Sector)
                .ToList();
            return View(opportunities);
        }
    }
}
