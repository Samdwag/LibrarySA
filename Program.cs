/*
 * Sami Alzoubi
 * CPSC 23000
 * February 20th, 2024
 * Library
 */




using System;
using static System.Console;



namespace LibrarySA
{
    internal class Program
    {
        static Library library = new Library();

        static void PrintHeading()
        {
            Console.WriteLine("*******************************************************");
            Console.WriteLine("        LIBRARY MANAGEMENT SYSTEM VERSION 1.0");
            Console.WriteLine("*******************************************************");
            Console.WriteLine("This tool helps you manage a library's collections.");
            Console.WriteLine("Please use the menu to choose what you want to do.");
            Console.WriteLine();
        }

        static void PrintMenu()
        {
            Console.WriteLine("Here are your options:");
            Console.WriteLine("1. List holdings");
            Console.WriteLine("2. Add a book");
            Console.WriteLine("3. Add a periodical");
            Console.WriteLine("4. Reserve a holding");
            Console.WriteLine("5. Return a holding");
            Console.WriteLine("6. See statistics");
            Console.WriteLine("7. Quit");
            Console.Write("Enter the number of your choice: ");
        }

        static void Main(string[] args)
        {
            PrintHeading();
            int choice;

            do
            {
                PrintMenu();
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        library.ListHoldings();
                        break;
                    case 2:
                        AddBook();
                        break;
                    case 3:
                        AddPeriodical();
                        break;
                    case 4:
                        // Logic for reserving a holding
                        break;
                    case 5:
                        // Logic for returning a holding
                        break;
                    case 6:
                        // Logic for seeing statistics
                        break;
                    case 7:
                        Console.WriteLine("Thank you for using this program.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 7.");
                        break;
                }
                Console.WriteLine();
            } while (choice != 7);
        }

        static void AddBook()
        {
            Console.Write("Enter book ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter book title: ");
            string title = Console.ReadLine();
            Console.Write("Enter book description: ");
            string description = Console.ReadLine();
            Console.Write("Enter book author: ");
            string author = Console.ReadLine();
            Console.Write("Enter book copyright year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            Book book = new Book(id, title, description, year, author);
            library.AddHolding(book);
            Console.WriteLine("Book added successfully.");
        }

        static void AddPeriodical()
        {
            Console.Write("Enter periodical ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter periodical title: ");
            string title = Console.ReadLine();
            Console.Write("Enter periodical description: ");
            string description = Console.ReadLine();
            Console.Write("Enter publication date (MM/DD/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Periodical periodical = new Periodical(id, title, description, date);
            library.AddHolding(periodical);
            Console.WriteLine("Periodical added successfully.");
        }
    }
}