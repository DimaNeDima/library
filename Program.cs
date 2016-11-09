using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CourseWork2
{
    [Serializable]
    class Book
    {
        public string title;
        public string author;
        public Book(string t, string a)
        {
            this.title = t; this.author = a;
        }
        public override string ToString()
        {
            return author + " «" + title + '»';
        }
    }
    [Serializable]
    class Reader
    {
        public string name;
        public List<Book> books;
        public Reader(string n, List<Book> b)
        {
            this.name = n;
            this.books = b;
        }
        public override string ToString()
        {
            return name;
        }
    }
 
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Lib());
        }
    }
}
