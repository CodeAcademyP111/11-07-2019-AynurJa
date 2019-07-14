using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public static  class Book_Center
    {
        private readonly static List<Book> _books;
        static Book_Center()
        {
            _books = new List<Book>
            {
                new Book {BookName="Pride & Prejudice",ISBN=20182019,Price=18,Author="Jane Austen"},
                new Book {BookName="Me before you",ISBN=20182020,Price=20,Author="Jojo Moyes"},
                new Book {BookName="Suc ve Ceza",ISBN=56879425,Price=25,Author="Fyodor Dostoyevski"},
                new Book {BookName="The Magic",ISBN=20199186,Price=35,Author="Rhonda Byrne"},
                new Book {BookName="The Brain",ISBN=2578946,Price=15,Author="David Eagleman"}

            };
        }
        public  static List<Book> GetBooks()
        {
            return _books;
        }
         public static void AddBook(Book book)
        {
            _books.Add(book);
        }
        public static bool DeleteByBookName(string bookname)
        {
            for (int i = 0; i < _books.Count; i++)
            {
                if(_books[i].BookName== bookname)
                {
                    _books.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public static Book GetByBookName(string bookname)
        {
            for (int i = 0; i < _books.Count; i++)
            {
                if (_books[i].BookName == bookname)
                {
                    _books.RemoveAt(i);
                    return _books[i] ;
                }
            }
            return null;
        }
    }
}
