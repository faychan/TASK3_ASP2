using System.Web.Mvc;
using ASP_MVC_2.Security;

namespace ASP_MVC_2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult Welcome()
        {
            return View();
        }

        [AuthorizeRole("Admin")]
        public ActionResult AdminOnly() {
            return View();
        }
        public ActionResult UnAuthorized(){
           return View();
        }
    }
}