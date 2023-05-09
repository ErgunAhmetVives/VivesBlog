using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VivesBlog.Core;
using VivesBlog.Models;

namespace VivesBlog.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
        private readonly BlogDatabase _blogDatabase;

        public HomeController(ILogger<HomeController> logger, BlogDatabase blogDatabase)
		{
			_blogDatabase= blogDatabase;
			_logger = logger;
		}


        [HttpGet("")]
        public IActionResult Index()
		{
			var list = _blogDatabase.blogArtikel;
			return View(list);
		}

        [HttpGet]
        public IActionResult Privacy()
		{
			return View();
		}

        [HttpGet("/home/detail/{id}")]
        public IActionResult Detail(int id)
        {
            var list = _blogDatabase.blogArtikel;
            var person = list.FirstOrDefault(x => x.Id == id);
            if (person == null)
            {
                return RedirectToAction("Index");
            } 
            return View(person);
        }

        [HttpGet]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}


    }
}