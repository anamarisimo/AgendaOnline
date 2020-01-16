using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AgendaOnline.Controllers
{

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["message_short"] = "Bine ai venit";
            ViewData["message_long"]  = "This simple web app is made using ASP.NET Core 2.1 MVC and hosted on Azure Cloud Services.";
            return View();
        }

        public IActionResult About()
        {
            ViewData["message"] = "Aceasta este o aplicatie care te ajuta sa fii organizat! ";
            return View();
        }
    }
}