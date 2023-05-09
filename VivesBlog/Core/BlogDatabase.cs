using VivesBlog.Models;

namespace VivesBlog.Core
{
    public class BlogDatabase
    {
        public IList<BlogArtikel> blogArtikel { get; set; } = new List<BlogArtikel>();

        public void Seed()
        {
            blogArtikel = new List<BlogArtikel>
            {
                new BlogArtikel {Id = 1, Title ="First Article", Description="this is the first article" },
                new BlogArtikel {Id = 2, Title= "Second Article", Description="This is the second article"},
                new BlogArtikel {Id = 3, Title ="Third article", Description="this is the third article"},
                new BlogArtikel {Id = 4, Title ="fourth article", Description="this is the fourth article"}
            };
        }
    }
}
