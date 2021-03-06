using System;
using System.Collections.Generic;
using System.Text;

namespace BookCatalog
{
    public class BookCatalogDictionary
    {
        #region Instance fields
        private Dictionary<string, Book> _books;
        #endregion

        #region Constructor
        public BookCatalogDictionary()
        {
            _books = new Dictionary<string, Book>();
        }
        #endregion

        #region Properties
        public int Count
        {
            get { return _books.Count; }
        }
        #endregion

        #region Methods
        /// <summary>
        /// This method adds a single Book object 
        /// to the List of books 
        /// </summary>
        public void AddBook(Book aBook)
        {
            if (LookupBook(aBook.ISBN) == null)
            {
                _books.Add(aBook.ISBN, aBook);
            }
            // TODO
        }

        /// <summary>
        /// This method returns a Book object (if any) from
        /// the List of books, which has a matching ISBN number.
        /// If no such object exists, the method returns null.
        /// </summary>
        public Book LookupBook(string isbn)
        {
            // TODO
            //Book foundBook;
            //if (_books.TryGetValue(isbn, out foundBook))
            //    return foundBook;
            //else
            //    return null;
            if (_books.ContainsKey(isbn))
            {
                return _books[isbn];
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// This method deletes a Book object from the List
        /// of books, specifically the object which has a
        /// matching ISBN number. If no such object exists,
        /// no object is deleted.
        /// </summary>
        public void DeleteBook(string isbn)
        {
            // TODO
            _books.Remove(isbn);
        }

        public void PrintBooks()
        {
            foreach (Book book in _books.Values)
            {
                Console.WriteLine(book);
            }

        }

        #endregion
    }
}
