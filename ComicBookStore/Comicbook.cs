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
        public int UPC { get; set; }
        public int IssueNumber { get; set; }
        public string CoverImage { get; set; }
        public string Author { get; set; }
        public string Illustrator { get; set; }
        public double Price { get; set; }
        public bool VariantCover { get; set; }
        public bool Reprint { get; set; }

        public Comicbook(string seriesTitle, int upc, int issueNumber, string coverImage, string author, string illustrator, double price, bool variantCover, bool reprint)
        {
            SeriesTitle = seriesTitle;
            UPC = upc;
            IssueNumber = issueNumber;
            CoverImage = coverImage;
            Author = author;
            Illustrator = illustrator;
            Price = price;
            VariantCover = variantCover;
            Reprint = reprint;
        }

       

    }
}
