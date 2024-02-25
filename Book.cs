using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySA
{
    internal class Book : Holding
    {
        public int CopyrightYear { get; set; }
        public string Author { get; set; }

        public Book() : base()
        {
            CopyrightYear = 0;
            Author = string.Empty;
        }

        public Book(int id, string title, string description, int copyrightYear, string author)
            : base(id, title, description)
        {
            CopyrightYear = copyrightYear;
            Author = author;
        }

        public override string HoldingType()
        {
            return "Book";
        }

        public override string ToString()
        {
            return base.ToString() + $"\t{Author}\t{CopyrightYear}";
        }
    }
}
