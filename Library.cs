using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySA
{
    internal class Library
    {
        private List<Holding> holdings;

        public Library()
        {
            holdings = new List<Holding>();
        }

        public void AddHolding(Holding holding)
        {
            holdings.Add(holding);
        }

        public void ListHoldings()
        {
            Console.WriteLine("Here are the library's holdings:");
            Console.WriteLine("These holdings are checked out:");
            var checkedOutHoldings = holdings.Where(h => h.IsCheckedOut).ToList();
            if (checkedOutHoldings.Count == 0)
            {
                Console.WriteLine("No holdings are checked out.");
            }
            else
            {
                foreach (var holding in checkedOutHoldings)
                {
                    Console.WriteLine(holding);
                }
            }

            Console.WriteLine("These holdings are available:");
            var availableHoldings = holdings.Where(h => !h.IsCheckedOut).ToList();
            if (availableHoldings.Count == 0)
            {
                Console.WriteLine("No holdings are available.");
            }
            else
            {
                foreach (var holding in availableHoldings)
                {
                    Console.WriteLine(holding);
                }
            }
        }

        public Holding FindHolding(int id)
        {
            return holdings.FirstOrDefault(h => h.Id == id);
        }

        public bool ReserveHolding(int id)
        {
            var holding = FindHolding(id);
            if (holding != null && !holding.IsCheckedOut)
            {
                holding.Checkout();
                Console.WriteLine("You have checked it out.");
                return true;
            }
            else
            {
                Console.WriteLine("There was a problem with your request.");
                return false;
            }
        }

        public bool ReturnHolding(int id)
        {
            var holding = FindHolding(id);
            if (holding != null && holding.IsCheckedOut)
            {
                holding.CheckIn();
                Console.WriteLine("You have checked it in.");
                return true;
            }
            else
            {
                Console.WriteLine("There was a problem with your request.");
                return false;
            }
        }

        public void GetStatistics()
        {
            int checkedOutCount = holdings.Count(h => h.IsCheckedOut);
            int availableCount = holdings.Count - checkedOutCount;
            Console.WriteLine($"Available: {availableCount}");
            Console.WriteLine($"Checked out: {checkedOutCount}");
        }
    }
}