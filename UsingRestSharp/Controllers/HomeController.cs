using Microsoft.AspNetCore.Mvc;
using UsingRestSharp.Models;

namespace UsingRestSharp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var allArticles = Article.GetArticles(EnvironmentVariables.ApiKey);
            return View(allArticles);
        }
        
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
