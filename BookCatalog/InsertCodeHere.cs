using System;

namespace BookCatalog
{
    class InsertCodeHere
    {
        

        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line
            BookCatalogList bookCatalogList = new BookCatalogList();
            BookCatalogDictionary bookCatalogDictionary = new BookCatalogDictionary();
            Menu menu = new Menu(bookCatalogList, bookCatalogDictionary);
            menu.Run();

            

            //Test af AddBook
            //Book firstBook = new Book("121212", "C# programming", "John Sharp", 597);
            //Console.WriteLine($"Antal bøger inden add af bog {bookCatalogList.Count  }");
            //bookCatalogList.AddBook(firstBook);
            //Book secondBook = new Book("131313", "Pascal programming", "John Pascal", 444);
            //Book thirdBook = new Book("141414", "Python programming", "John Python", 888);
            //bookCatalogList.AddBook(secondBook);
            //bookCatalogList.AddBook(thirdBook);
            //Console.WriteLine($"Antal bøger efter add af 3 bøger {bookCatalogList.Count  }");

            ////Test af LookUpBook
            //Book foundBook = bookCatalogList.LookupBook("131313");
            //if (foundBook != null)
            //{
            //    //Udskriv foundBook
            //    Console.WriteLine($"Bog fundet { foundBook.ToString()}");
            //}
            //else
            //{
            //    //Udskriv bog ikke fundet
            //    Console.WriteLine("Bog ikke fundet");
            //}

            ////Test af DeleteBook
            ////Console.WriteLine($"Antal bøger inden delete af bog {bookCatalogList.Count  }");
            ////bookCatalogList.DeleteBook("131313");
            ////Console.WriteLine($"Antal bøger efter delete af bog {bookCatalogList.Count  }");

            //Console.WriteLine("Print books");
            //bookCatalogList.PrintBooks();
            //Book upDatedBook = new Book("131313", "C# 2.0 programming", "John Sharp v2", 450);
            //bookCatalogList.UpdateBook("131313", upDatedBook);
            //Console.WriteLine("Print books after update");
            //bookCatalogList.PrintBooks();

            //Console.WriteLine("Test of BookCatalogDictionary");

            //BookCatalogDictionary bookCatalogDictionary = new BookCatalogDictionary();
            //bookCatalogDictionary.AddBook(firstBook);
            //bookCatalogDictionary.AddBook(secondBook);
            //bookCatalogDictionary.AddBook(thirdBook);
            //bookCatalogDictionary.PrintBooks();


            //Book newBook = new Book("131313", "bla bla bla", "John bla", 45455);
            //bookCatalogDictionary.AddBook(newBook);
            //bookCatalogDictionary.DeleteBook("141414");

            //Console.WriteLine("Books after add(with existing isbn and delete af book with isbn 141414");
            //bookCatalogDictionary.PrintBooks();
            // The LAST line of code should be ABOVE this line
        }
    }
    
}
