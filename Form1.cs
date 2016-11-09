using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace CourseWork2
{
    public partial class Lib : Form
    {
        Library library;
        public Lib()
        {
            library = new Library(new List<Book>(), new List<Reader>(), new List<Book>());
            InitializeComponent();
        }

        private void AddBooks()
        {
            Book b = new Book(Title.Text, Author.Text);
            ListOfBooks.Items.Insert(ListOfBooks.Items.Count, b);
            AllBooks.Items.Insert(AllBooks.Items.Count, b);
            library.Books.Add(b);
            library.BooksLeft.Add(b);
            Author.Text = "";
            Title.Text = "";
        }
        private void AddReaders()
        {
            Reader r = new Reader(Readers.Text, new List<Book>());
            ListOfReaders.Items.Insert(library.Readers.Count, r);
            AllReaders.Items.Insert(library.Readers.Count, r);
            library.Readers.Add(r);
            Readers.Text = "";
        }
        private void DeleteReader(int delIndex)
        {
            DeleteBooksFromLibrary(library.Readers[delIndex].books);
            library.Readers.RemoveAt(delIndex);
            ListOfReaders.Items.RemoveAt(delIndex);
            AllReaders.Items.RemoveAt(delIndex);
            ReaderBooks.Items.Clear();
        }
        private void DeleteBooksFromLibrary(List<Book> b)
        {
            for (int i = 0; i < b.Count; i++)
            {
                int delIndex = ListOfBooks.FindStringExact(b[i].ToString());
                ListOfBooks.Items.RemoveAt(delIndex);
                library.Books.RemoveAt(delIndex);
            }
        }
        private void ShowBooks(object sender, EventArgs e)
        {
            ReaderBooks.Items.Clear();
            if (AllReaders.SelectedIndex != -1)
            {
                List<Book> b = library.Readers[AllReaders.SelectedIndex].books;
                for (int i = 0; i < b.Count; i++)
                {
                    ReaderBooks.Items.Insert(i, b[i]);
                }
            }
        }
        private void TakeBooks()
        {
            Book book = library.BooksLeft[AllBooks.SelectedIndex];
            Reader reader = library.Readers[AllReaders.SelectedIndex];
            reader.books.Add(book);
            ReaderBooks.Items.Add(book);
            library.BooksLeft.Remove(book);
            AllBooks.Items.RemoveAt(AllBooks.SelectedIndex);
        }
        private void ReturnBooks()
        {
            Reader reader = library.Readers[AllReaders.SelectedIndex];
            Book book = reader.books[ReaderBooks.SelectedIndex];
            library.BooksLeft.Add(book);
            AllBooks.Items.Add(book);
            reader.books.Remove(book);
            ReaderBooks.Items.RemoveAt(ReaderBooks.SelectedIndex);
            TakeBook.Show();
            ReaderBooks.Enabled = true;
            AllReaders.Enabled = true;
        }
        private void OpenSavedLibrary(Library l)
        {
            for (int i = 0; i < l.Books.Count; i++)
            {
                ListOfBooks.Items.Insert(i, l.Books[i]);
            }
            for (int i = 0; i < l.BooksLeft.Count; i++)
            {
                AllBooks.Items.Insert(i, l.BooksLeft[i]);
            }
            for (int i = 0; i < l.Readers.Count; i++)
            {
                AllReaders.Items.Insert(i, l.Readers[i]);
                ListOfReaders.Items.Insert(i, l.Readers[i]);
            }
            if (AllReaders.Items.Count != 0)
            {
                AllReaders.SelectedIndex = 0;
                for (int i = 0; i < l.Readers[0].books.Count; i++)
                {
                    ReaderBooks.Items.Insert(i, l.Readers[0].books[i]);
                }
            }
        }

        private void AddBook_Click(object sender, EventArgs e)
        {
            if ((Title.Text == "") || (Author.Text == ""))
            {
                MessageBox.Show("Введите автора и название книги", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AddBooks();
            }
        }
        private void AddReader_Click(object sender, EventArgs e)
        {
            if (Readers.Text == "")
            {
                MessageBox.Show("Введите имя читателя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AddReaders();
            }
        }
        private void TakeBook_Click(object sender, EventArgs e)
        {
            if ((AllBooks.Items.Count == 0) || (AllBooks.SelectedIndex == -1) || (AllReaders.Items.Count == 0) || (AllReaders.SelectedIndex == -1))
            {
                MessageBox.Show("Выберите читателя и книгу, которую вы хотите взять", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Reader reader = library.Readers[AllReaders.SelectedIndex];
                if (reader.books.Count == 5)
                {
                    if (MessageBox.Show("Вы не можете брать больше 5 книг. Хотите вернуть книгу?", "Невозможно", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.Yes)
                    {
                        TakeBook.Hide();
                        AllReaders.Enabled = false;
                    }
                    else
                    {
                        if (MessageBox.Show("Если вы не вернете книгу, то перестанете быть читателем нашей библиотеки. Хотите вернуть книгу?", "Невозможно", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                        {
                            TakeBook.Hide();
                            AllReaders.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Извините, вы исключены из списка читателей нашей библиотеки.", "Сожалеем", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DeleteReader(AllReaders.SelectedIndex);
                        }
                    }
                }
                else
                {
                    TakeBooks();
                }
            }
        }
        private void ReturnBook_Click(object sender, EventArgs e)
        {
            if ((ReaderBooks.Items.Count == 0) || (ReaderBooks.SelectedIndex == -1) || (AllReaders.Items.Count == 0) || (AllReaders.SelectedIndex == -1))
            {
                MessageBox.Show("Выберите читателя и книгу, которую хотите вернуть", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ReturnBooks();
            }
        }
        private void ClearBooksLeft_Click(object sender, EventArgs e)
        {
            DeleteBooksFromLibrary(library.BooksLeft);
            library.BooksLeft.Clear();
            AllBooks.Items.Clear();
        }
        private void ClearAllReaders_Click(object sender, EventArgs e)
        {
            while (library.Readers.Count != 0)
                DeleteReader(0);
        }
        private void ClearAll_Click(object sender, EventArgs e)
        {
            library.Readers.Clear();
            library.Books.Clear();
            library.BooksLeft.Clear();
            AllBooks.Items.Clear();
            AllReaders.Items.Clear();
            ListOfBooks.Items.Clear();
            ListOfReaders.Items.Clear();
            ReaderBooks.Items.Clear();
            Readers.Clear();
            Author.Clear();
            Title.Clear();
        }

        private void AllReaders_SelectedIndexChanged(object sender, EventArgs e)
        {
            AllReaders.SelectedIndexChanged += ShowBooks;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            Stream file = new FileStream("lib.dat", FileMode.Create, FileAccess.Write, FileShare.None);
            bf.Serialize(file, library);
            file.Close(); 
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            Stream file = File.OpenRead("lib.dat");
            library = (Library)(bf.Deserialize(file));
            file.Close();
            OpenSavedLibrary(library);
        }

        private void MakeToReturn_Click(object sender, EventArgs e)
        {
            if ((ReaderBooks.Items.Count == 0) || (ReaderBooks.SelectedIndex == -1) || (AllReaders.Items.Count == 0) || (AllReaders.SelectedIndex == -1))
            {
                MessageBox.Show("Выберите читателя и книгу, которую вы хотите, чтоб он вернул", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Book book = library.Readers[AllReaders.SelectedIndex].books[ReaderBooks.SelectedIndex];
                int index = ReaderBooks.SelectedIndex;
                if (MessageBox.Show("Вы слишком долго читаете книгу " + book + ". Вам пора её вернуть. Если вы откажетесь, то будете исключены из списка читателей библиотеки. Вы хотите вернуть книгу?", "Уведомление", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    TakeBook.Hide();
                    ReaderBooks.SelectedIndex = index;
                    ReaderBooks.Enabled = false;
                    AllReaders.Enabled = false;
                }
                else
                {
                        MessageBox.Show("Извините, вы исключены из списка читателей нашей библиотеки.", "Сожалеем", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DeleteReader(AllReaders.SelectedIndex);
                }
             }
          }
    }
}
