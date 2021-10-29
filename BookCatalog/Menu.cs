using System;
using System.Collections.Generic;
using System.Text;

namespace BookCatalog
{
    public class Menu
    {

        public Menu()
        {
            
        }

        public int ShowMenu()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("1. Tilføj bog til BookCatalogList");
            Console.WriteLine("2. Fjern bog bog fra BookCatalogList");
            Console.WriteLine("3. Opdater bog fra BookCatalogList");
            Console.WriteLine("4. Tilføj bog til BookCatalogDictionary");
            Console.WriteLine("5. Fjern bog bog fra BookCatalogDictionary");
            Console.WriteLine("6. Opdater bog fra BookCatalogDictionary");
            Console.WriteLine("Tast 0 for afslut");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Indtast dit valg:");
            string choice = Console.ReadLine();
            int input = -1;
            if (int.TryParse(choice, out input))
            {
                return input;
            }
            else
            {
                return -1;
            }
        }

        public void Run()
        {
            int valg = ShowMenu();
            while (valg != 0)
            {
                switch (valg)
                {
                    case 1: 
                        Console.Clear();
                        //Metode der indlæser og håndterer add Bog til BookCatalogList
                        AddBookToList();
                        break;
                    case 2: // todo
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Fejl i input");
                        break;
                }

                Console.Clear();
                valg = ShowMenu();

            }

        }

        private void AddBookToList()
        {
            Console.WriteLine("Angiv ISBN");
            string isbn = Console.ReadLine();
            Console.WriteLine("Angiv titel");
            string title = Console.ReadLine();
            Console.WriteLine("Angiv author");
            string author = Console.ReadLine();
            Console.WriteLine("Angiv antal sider");
            int noOfPages = int.Parse(Console.ReadLine());

            Book b = new Book(isbn, title, author, noOfPages);


        }
    }
}
