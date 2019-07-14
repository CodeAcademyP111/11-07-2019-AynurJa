using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreateBook_Click(object sender, EventArgs e)
        {
            string Bookname = textBox2.Text.Trim();
            int isbn = Convert.ToInt32(textBox3.Text);
            textBox3.Text = isbn.ToString();
            int price = Convert.ToInt32(textBox4.Text);
            textBox4.Text = price.ToString();
            string author = textBox5.Text.Trim();

            //Bookname validation
            if (Bookname == string.Empty)
            {
                MessageBox.Show("Bookname is empty", "Eror!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Add Book
            Book book = new Book();
            book.BookName = Bookname;
            book.Author = author;
            book.ISBN = isbn;
            book.Price = price;

            
              


                
            Book_Center.AddBook(book);
            ClearAddBookList();
            //Update dataGridView to show  new Book
            dgv.DataSource = null;
            dgv.DataSource = Book_Center.GetBooks();


        }

       private void ClearAddBookList()
       {
          textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = "";
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteBook deleteBook = new DeleteBook();
            deleteBook.FormClosed += UpdateDataGridWhenFormClosed;
          deleteBook.ShowDialog();

        }
        private void UpdateDataGridWhenFormClosed(object sender, EventArgs e)
        {
            dgv.DataSource = null;
            dgv.DataSource = Book_Center.GetBooks();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateBook updateBook = new UpdateBook();
            updateBook.ShowDialog();
        }
    }
}
