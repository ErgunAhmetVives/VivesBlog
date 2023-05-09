using Microsoft.AspNetCore.Mvc;
using System;
using VivesBlog.Core;
using VivesBlog.Models;

namespace VivesBlog.Controllers
{
	public class BlogArtikelController : Controller
	{
		private readonly BlogDatabase _blogDatabase;

        public BlogArtikelController(BlogDatabase blogDatabase)
        {
            _blogDatabase = blogDatabase;
        }

        [Route("/BlogArtikel")]
		[HttpGet]
		public IActionResult Index()
		{
			var blogArtikels = _blogDatabase.blogArtikel;
            return View(blogArtikels);
		}

	}
}
