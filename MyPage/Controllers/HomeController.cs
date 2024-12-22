using MyPage.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyPage.Models; 
using System.Diagnostics;

namespace MyPage.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyPageContext db; // Bağlantıyı ApplicationDbContext türüyle tanımlıyoruz.

        public HomeController(MyPageContext db) 
        {
           this.db = db;
        }

        public IActionResult Index()
        {


            var model = new PostsViewModel();
            model.Users = db.Users.ToList();
            return View(model);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
