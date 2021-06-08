using Microsoft.AspNetCore.Mvc;
using UsingRestSharp.Models;

namespace UsingRestSharp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var allArticles = Article.GetArticles("[YOUR-API-KEY-HERE]");
            return View(allArticles);
        }
        
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
