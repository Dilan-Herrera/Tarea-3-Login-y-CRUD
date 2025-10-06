using System.Web.Mvc;

namespace ProyectoMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (Session["User"] == null)
                return RedirectToAction("Login", "Account");

            ViewBag.Username = Session["User"].ToString();
            return View();
        }
    }
}
