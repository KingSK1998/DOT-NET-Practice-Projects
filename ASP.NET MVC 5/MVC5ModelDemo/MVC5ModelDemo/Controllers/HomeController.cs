using Microsoft.AspNetCore.Mvc;
using MVC5ModelDemo.Models;

namespace MVC5ModelDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        public ActionResult Index()
        {
            Product product = Product.GetProduct();
            return View(product);
        }

        // GET: /Home/Welcome/
        public string Welcome()
        {
            return "This is the welcome action method...";
        }
    }
}
