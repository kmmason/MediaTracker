using System.Web.Mvc;

namespace MediaTracker.Controllers
{
    public class MediaTrackerController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}