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
    public partial class DeleteBook : Form
    {
        public DeleteBook()
        {
            InitializeComponent();
        }

        private void DeleteBook_Load(object sender, EventArgs e)
        {
            foreach (var item in Book_Center.GetBooks())
            {
                cmbook.Items.Add(item.BookName);
            }
        }

        private void btnCreateBook_Click(object sender, EventArgs e)
        {
         DialogResult result= MessageBox.Show("Are you sure to delete student?","Confirmation!",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string selectBookName = cmbook.Text;
               if( Book_Center.DeleteByBookName(selectBookName))
                {
                    cmbook.Items.Clear();
                    foreach (var item in Book_Center.GetBooks())
                    {
                        cmbook.Items.Add(item.BookName);
                    }
                }
                else
                {
                    MessageBox.Show("Not Found");
                }
            }
        }
    }
}
