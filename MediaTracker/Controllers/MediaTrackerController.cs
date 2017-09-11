using MediaTracker.Models;
using MediaTracker.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace MediaTracker.Controllers
{
    public class MediaTrackerController : Controller
    {
        private ApplicationDbContext _context;

        public MediaTrackerController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            var viewModel = new MediaFormViewModel
            {
                Viewers = _context.Viewers.ToList()
            };
            return View(viewModel);
        }
    }
}