using System;
using System.Collections.Generic;
using System.Text;

namespace BookCatalog
{
    public class BookCatalogList
    {
        #region Instance fields
        private List<Book> _books;
        #endregion

        #region Constructor
        public BookCatalogList()
        {
            _books = new List<Book>();
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
            // TODO
            _books.Add(aBook);
            
        }

        /// <summary>
        /// This method returns a Book object (if any) from
        /// the List of books, which has a matching ISBN number.
        /// If no such object exists, the method returns null.
        /// </summary>
        public Book LookupBook(string isbn)
        {
            // TODO
            // Løb listen af bøger igennem
            // tag et bog objekt ud af gangen
            // sammenlign hver bogs isbn med det isbnnr der søges efter
            // hvis  søgte isbnnr findes så returner bogen (bog objektet)
            // hvis alle bøger er gennemløbet uden at have fundet bogen returnes null

            //foreach
            //foreach (Book book in _books)
            //{
            //    bool found = book.ISBN == isbn;
            //    if ( found  )
            //    {
            //        return book;
            //    }
            //}
            //return null;

            //While
            int j = 0;
            while (j < _books.Count)
            {
                Book book = _books[j];
                bool found = book.ISBN == isbn;
                if (found == true)
                {
                    return book;
                }
                j++;
            }
            return null;
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
            Book bookToBeRemoved = LookupBook(isbn);
            if (bookToBeRemoved != null)
            {
                bool removed = _books.Remove(bookToBeRemoved);
            }
        }



        #endregion
    }
}
