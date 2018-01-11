using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenWeb01.Models
{
    public class ListeArticle
    {
        public List<GetAllGenreResult> GenreList { get; set; }
        public List<GetAllArticleResult> ArticleList { get; set; }
        public List<GetAllCollResult> CollList { get; set; }

    }
}