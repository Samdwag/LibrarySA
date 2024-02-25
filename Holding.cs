using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySA
{
    internal abstract class Holding
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsCheckedOut { get; set; }

        public Holding()
        {
            Id = 0;
            Title = string.Empty;
            Description = string.Empty;
            IsCheckedOut = false;
        }

        public Holding(int id, string title, string description)
        {
            Id = id;
            Title = title;
            Description = description;
            IsCheckedOut = false;
        }

        public void Checkout()
        {
            IsCheckedOut = true;
        }

        public void CheckIn()
        {
            IsCheckedOut = false;
        }

        public abstract string HoldingType();

        public override string ToString()
        {
            return $"{Id}\t{Title}\t{Description}\t{(IsCheckedOut ? "Checked Out" : "Available")}";
        }
    }
}
