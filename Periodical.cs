using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySA
{
    internal class Periodical : Holding
    {
        public DateTime Date { get; set; }

        public Periodical() : base()
        {
            Date = DateTime.MinValue;
        }

        public Periodical(int id, string title, string description, DateTime date)
            : base(id, title, description)
        {
            Date = date;
        }

        public override string HoldingType()
        {
            return "Periodical";
        }

        public override string ToString()
        {
            return base.ToString() + $"\t{Date.ToString("MMMM d, yyyy")}";
        }
    }
}