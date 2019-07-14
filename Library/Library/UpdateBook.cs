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
    public partial class UpdateBook : Form
    {
        private Book bookToUpdate = null;
        public UpdateBook()
        {
            InitializeComponent();
        }

        private void pnlEdit_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void lblBookIsbn_Click(object sender, EventArgs e)
        {

        }

        

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            string Bookname = textBox2.Text.Trim();
            int isbn = Convert.ToInt32(textBox3.Text);
            textBox3.Text = isbn.ToString();
            int price = Convert.ToInt32(textBox4.Text);
            textBox4.Text = price.ToString();
            //string author = textBox5.Text.Trim();

            //Update Book
            bookToUpdate.BookName = Bookname;
         DialogResult result=MessageBox.Show("Book was succesfully updated","Success!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            if(result != 0)
            {
                Close();
            }
        }


        private void UpdateBook_Load(object sender, EventArgs e)
        {
            UpdateBookDropdown();
        }
       private  void UpdateBookDropdown()
        {
            cmbook.Items.Clear();
            foreach (var item in Book_Center.GetBooks())
            {
                cmbook.Items.Add(item.BookName);
            }
        }

        private void cmbook_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedBookName = cmbook.Text;
            bookToUpdate = Book_Center.GetByBookName(selectedBookName);
            if(bookToUpdate != null)
            {
                textBox2.Text = bookToUpdate.BookName;
                pnlEdit.Visible = true;
            }
           
        }

        
    }
}
