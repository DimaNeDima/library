namespace CourseWork2
{
    partial class Lib
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.AddBook = new System.Windows.Forms.Button();
            this.ListOfBooks = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Author = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.Readers = new System.Windows.Forms.TextBox();
            this.AddReader = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ListOfReaders = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ReturnBook = new System.Windows.Forms.Button();
            this.TakeBook = new System.Windows.Forms.Button();
            this.ReaderBooks = new System.Windows.Forms.ListBox();
            this.AllReaders = new System.Windows.Forms.ListBox();
            this.AllBooks = new System.Windows.Forms.ListBox();
            this.ClearBooksLeft = new System.Windows.Forms.Button();
            this.ClearAllReaders = new System.Windows.Forms.Button();
            this.ClearAll = new System.Windows.Forms.Button();
            this.MakeToReturn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(673, 327);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::CourseWork2.Properties.Resources.Library;
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.AddBook);
            this.tabPage1.Controls.Add(this.ListOfBooks);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Author);
            this.tabPage1.Controls.Add(this.Title);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(665, 301);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Книги в библиотеке";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(35, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Список книг в библиотеке:";
            // 
            // AddBook
            // 
            this.AddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddBook.Location = new System.Drawing.Point(413, 193);
            this.AddBook.Name = "AddBook";
            this.AddBook.Size = new System.Drawing.Size(170, 47);
            this.AddBook.TabIndex = 5;
            this.AddBook.Text = "Добавить в библиотеку";
            this.AddBook.UseVisualStyleBackColor = true;
            this.AddBook.Click += new System.EventHandler(this.AddBook_Click);
            // 
            // ListOfBooks
            // 
            this.ListOfBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListOfBooks.FormattingEnabled = true;
            this.ListOfBooks.HorizontalScrollbar = true;
            this.ListOfBooks.ItemHeight = 16;
            this.ListOfBooks.Location = new System.Drawing.Point(21, 45);
            this.ListOfBooks.Name = "ListOfBooks";
            this.ListOfBooks.Size = new System.Drawing.Size(344, 212);
            this.ListOfBooks.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(426, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите автора книги";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(410, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите название книги";
            // 
            // Author
            // 
            this.Author.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Author.Location = new System.Drawing.Point(402, 64);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(195, 23);
            this.Author.TabIndex = 1;
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.Location = new System.Drawing.Point(402, 143);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(195, 23);
            this.Title.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::CourseWork2.Properties.Resources.Readers;
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.Readers);
            this.tabPage2.Controls.Add(this.AddReader);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.ListOfReaders);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(665, 301);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Читатели библиотеки";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(4, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Список читателей библиотеки:";
            // 
            // Readers
            // 
            this.Readers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Readers.Location = new System.Drawing.Point(228, 107);
            this.Readers.Name = "Readers";
            this.Readers.Size = new System.Drawing.Size(161, 24);
            this.Readers.TabIndex = 3;
            // 
            // AddReader
            // 
            this.AddReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddReader.Location = new System.Drawing.Point(249, 154);
            this.AddReader.Name = "AddReader";
            this.AddReader.Size = new System.Drawing.Size(120, 29);
            this.AddReader.TabIndex = 2;
            this.AddReader.Text = "Добавить читателя";
            this.AddReader.UseVisualStyleBackColor = true;
            this.AddReader.Click += new System.EventHandler(this.AddReader_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(225, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Введите имя читателя";
            // 
            // ListOfReaders
            // 
            this.ListOfReaders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListOfReaders.FormattingEnabled = true;
            this.ListOfReaders.ItemHeight = 16;
            this.ListOfReaders.Location = new System.Drawing.Point(7, 54);
            this.ListOfReaders.Name = "ListOfReaders";
            this.ListOfReaders.Size = new System.Drawing.Size(212, 180);
            this.ListOfReaders.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::CourseWork2.Properties.Resources.Library2;
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.ReturnBook);
            this.tabPage3.Controls.Add(this.TakeBook);
            this.tabPage3.Controls.Add(this.ReaderBooks);
            this.tabPage3.Controls.Add(this.AllReaders);
            this.tabPage3.Controls.Add(this.AllBooks);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(665, 301);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Выдача и возврат книг";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(522, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Список читателей:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(329, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Список книг читателя:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Список оставшихся книг:";
            // 
            // ReturnBook
            // 
            this.ReturnBook.BackColor = System.Drawing.Color.Transparent;
            this.ReturnBook.BackgroundImage = global::CourseWork2.Properties.Resources.LeftArrow;
            this.ReturnBook.Location = new System.Drawing.Point(214, 198);
            this.ReturnBook.Name = "ReturnBook";
            this.ReturnBook.Size = new System.Drawing.Size(100, 50);
            this.ReturnBook.TabIndex = 4;
            this.ReturnBook.UseVisualStyleBackColor = false;
            this.ReturnBook.Click += new System.EventHandler(this.ReturnBook_Click);
            // 
            // TakeBook
            // 
            this.TakeBook.BackColor = System.Drawing.Color.Transparent;
            this.TakeBook.BackgroundImage = global::CourseWork2.Properties.Resources.RightArrow;
            this.TakeBook.Font = new System.Drawing.Font("Marlett", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TakeBook.Location = new System.Drawing.Point(214, 95);
            this.TakeBook.Name = "TakeBook";
            this.TakeBook.Size = new System.Drawing.Size(100, 50);
            this.TakeBook.TabIndex = 3;
            this.TakeBook.UseVisualStyleBackColor = false;
            this.TakeBook.Click += new System.EventHandler(this.TakeBook_Click);
            // 
            // ReaderBooks
            // 
            this.ReaderBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReaderBooks.FormattingEnabled = true;
            this.ReaderBooks.HorizontalScrollbar = true;
            this.ReaderBooks.ItemHeight = 16;
            this.ReaderBooks.Location = new System.Drawing.Point(320, 71);
            this.ReaderBooks.Name = "ReaderBooks";
            this.ReaderBooks.Size = new System.Drawing.Size(189, 212);
            this.ReaderBooks.TabIndex = 2;
            // 
            // AllReaders
            // 
            this.AllReaders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllReaders.FormattingEnabled = true;
            this.AllReaders.ItemHeight = 16;
            this.AllReaders.Location = new System.Drawing.Point(525, 71);
            this.AllReaders.Name = "AllReaders";
            this.AllReaders.Size = new System.Drawing.Size(130, 212);
            this.AllReaders.TabIndex = 1;
            this.AllReaders.SelectedIndexChanged += new System.EventHandler(this.AllReaders_SelectedIndexChanged);
            // 
            // AllBooks
            // 
            this.AllBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllBooks.FormattingEnabled = true;
            this.AllBooks.HorizontalScrollbar = true;
            this.AllBooks.ItemHeight = 16;
            this.AllBooks.Location = new System.Drawing.Point(6, 71);
            this.AllBooks.Name = "AllBooks";
            this.AllBooks.Size = new System.Drawing.Size(202, 212);
            this.AllBooks.TabIndex = 0;
            // 
            // ClearBooksLeft
            // 
            this.ClearBooksLeft.Location = new System.Drawing.Point(678, 24);
            this.ClearBooksLeft.Name = "ClearBooksLeft";
            this.ClearBooksLeft.Size = new System.Drawing.Size(84, 80);
            this.ClearBooksLeft.TabIndex = 1;
            this.ClearBooksLeft.Text = "Очистить список книг, оставшихся в библиотеке";
            this.ClearBooksLeft.UseVisualStyleBackColor = true;
            this.ClearBooksLeft.Click += new System.EventHandler(this.ClearBooksLeft_Click);
            // 
            // ClearAllReaders
            // 
            this.ClearAllReaders.Location = new System.Drawing.Point(678, 110);
            this.ClearAllReaders.Name = "ClearAllReaders";
            this.ClearAllReaders.Size = new System.Drawing.Size(84, 63);
            this.ClearAllReaders.TabIndex = 2;
            this.ClearAllReaders.Text = "Очистить список читателей библиотеки";
            this.ClearAllReaders.UseVisualStyleBackColor = true;
            this.ClearAllReaders.Click += new System.EventHandler(this.ClearAllReaders_Click);
            // 
            // ClearAll
            // 
            this.ClearAll.Location = new System.Drawing.Point(678, 179);
            this.ClearAll.Name = "ClearAll";
            this.ClearAll.Size = new System.Drawing.Size(84, 48);
            this.ClearAll.TabIndex = 3;
            this.ClearAll.Text = "Очистить всё";
            this.ClearAll.UseVisualStyleBackColor = true;
            this.ClearAll.Click += new System.EventHandler(this.ClearAll_Click);
            // 
            // MakeToReturn
            // 
            this.MakeToReturn.Location = new System.Drawing.Point(678, 248);
            this.MakeToReturn.Name = "MakeToReturn";
            this.MakeToReturn.Size = new System.Drawing.Size(84, 68);
            this.MakeToReturn.TabIndex = 4;
            this.MakeToReturn.Text = "Заставить читателя вернуть книгу";
            this.MakeToReturn.UseVisualStyleBackColor = true;
            this.MakeToReturn.Click += new System.EventHandler(this.MakeToReturn_Click);
            // 
            // Lib
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(767, 328);
            this.Controls.Add(this.MakeToReturn);
            this.Controls.Add(this.ClearAll);
            this.Controls.Add(this.ClearAllReaders);
            this.Controls.Add(this.ClearBooksLeft);
            this.Controls.Add(this.tabControl1);
            this.Name = "Lib";
            this.Text = "Library";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.TextBox Author;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.TextBox Readers;

        private System.Windows.Forms.ListBox ListOfBooks;
        private System.Windows.Forms.ListBox ListOfReaders;
        private System.Windows.Forms.ListBox ReaderBooks;
        private System.Windows.Forms.ListBox AllReaders;
        private System.Windows.Forms.ListBox AllBooks;

        private System.Windows.Forms.Button AddBook;
        private System.Windows.Forms.Button AddReader;
        private System.Windows.Forms.Button ReturnBook;
        private System.Windows.Forms.Button TakeBook;
        private System.Windows.Forms.Button ClearBooksLeft;
        private System.Windows.Forms.Button ClearAll;
        private System.Windows.Forms.Button ClearAllReaders;
        private System.Windows.Forms.Button MakeToReturn;
    }
}

