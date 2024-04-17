using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicBookStore
{
    internal class Comicbook
    {

        public string SeriesTitle { get; set; }
        public int IssueNumber { get; set; }
        public string CoverImage { get; set; }
        public string Author { get; set; }
        public string Illustrator { get; set; }
        public double Price { get; set; }
        public bool VarientCover { get; set; }
        public bool Reprint { get; set; }

        public Comicbook(string seriesTitle, int issueNumber, string coverImage, string author, string illustrator, double price, bool varientCover, bool reprint)
        {
            SeriesTitle = seriesTitle;
            IssueNumber = issueNumber;
            CoverImage = coverImage;
            Author = author;
            Illustrator = illustrator;
            Price = price;
            VarientCover = varientCover;
            Reprint = reprint;
        }

        public Comicbook()
        {
        }
    }
}
