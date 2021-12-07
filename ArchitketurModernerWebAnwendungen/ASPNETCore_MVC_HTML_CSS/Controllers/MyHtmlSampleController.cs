using Microsoft.AspNetCore.Mvc;

namespace ASPNETCore_MVC_HTML_CSS.Controllers
{
    public class MyHtmlSampleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
