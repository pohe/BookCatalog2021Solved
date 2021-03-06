using System;
using System.Collections.Generic;
using System.Text;

namespace BookCatalog
{
    /// <summary>
    /// This class represent a book, with ISBN, title, author
    /// and the number of pages in the book
    /// </summary>
    public class Book
    {
        #region Instance fields
        private string _isbn;
        private string _title;
        private string _author;
        private int _noOfPages;
        #endregion

        #region Constructor
        public Book(string isbn, string title, string author, int noOfPages)
        {
            _isbn = isbn;
            _title = title;
            _author = author;
            _noOfPages = noOfPages;
        }
        #endregion

        #region Properties
        public string ISBN
        {
            get { return _isbn; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Author
        {
            get { return _author; }
        }

        public int NoOfPages
        {
            get { return _noOfPages; }
        }

        #endregion

        public override string ToString()
        {
            return $"ISBN {_isbn}  Titel {_title}  Author {_author} number of pages {_noOfPages}";
        }
    }
}
