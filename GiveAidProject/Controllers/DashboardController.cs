using System.Web.Mvc;

namespace GiveAidProject.Controllers
{
    public class DashboardController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}