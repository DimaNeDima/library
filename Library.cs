using System;
using System.Collections.Generic;

namespace CourseWork2
{
    [Serializable]
    class Library
    {
        public List<Book> Books;
        public List<Reader> Readers;
        public List<Book> BooksLeft;
        public Library(List<Book> b, List<Reader> r, List<Book> bl)
        {
            Books = b;
            Readers = r;
            BooksLeft = bl;
        }     
    }
}
