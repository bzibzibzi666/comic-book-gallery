using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBasic.ComicBookGallery.Models
{
    public class ComicBook
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Issue { get; set; }
        public string DescriptionHtml { get; set; }
        public List<Artist> Artists { get; set; }
        public bool Fivorite { get; set; }
    }
}