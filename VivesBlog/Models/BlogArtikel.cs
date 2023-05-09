using System.ComponentModel.DataAnnotations;

namespace VivesBlog.Models
{
	public class BlogArtikel
	{
		[Required]
		public int Id { get; set; }
		[Required]
		public string Title { get; set; }
		[MinLength(10)]
		public string Description { get; set; }

	}
}
