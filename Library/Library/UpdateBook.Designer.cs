namespace Library
{
    partial class UpdateBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBookName = new System.Windows.Forms.Label();
            this.cmbook = new System.Windows.Forms.ComboBox();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.lblBookAuthor = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.lblBookPrice = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblBookIsbn = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblBookName);
            this.panel1.Controls.Add(this.cmbook);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 88);
            this.panel1.TabIndex = 0;
            // 
            // lblBookName
            // 
            this.lblBookName.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBookName.Location = new System.Drawing.Point(12, 9);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(121, 25);
            this.lblBookName.TabIndex = 10;
            this.lblBookName.Text = "Select Book";
            this.lblBookName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbook
            // 
            this.cmbook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbook.FormattingEnabled = true;
            this.cmbook.Location = new System.Drawing.Point(12, 49);
            this.cmbook.Name = "cmbook";
            this.cmbook.Size = new System.Drawing.Size(251, 21);
            this.cmbook.TabIndex = 9;
            this.cmbook.SelectedIndexChanged += new System.EventHandler(this.cmbook_SelectedIndexChanged);
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.lblBookAuthor);
            this.pnlEdit.Controls.Add(this.textBox5);
            this.pnlEdit.Controls.Add(this.btnUpdateBook);
            this.pnlEdit.Controls.Add(this.lblBookPrice);
            this.pnlEdit.Controls.Add(this.textBox4);
            this.pnlEdit.Controls.Add(this.lblBookIsbn);
            this.pnlEdit.Controls.Add(this.textBox3);
            this.pnlEdit.Controls.Add(this.textBox2);
            this.pnlEdit.Controls.Add(this.label1);
            this.pnlEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEdit.Location = new System.Drawing.Point(0, 88);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(336, 319);
            this.pnlEdit.TabIndex = 1;
            this.pnlEdit.Visible = false;
            this.pnlEdit.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlEdit_Paint);
            // 
            // lblBookAuthor
            // 
            this.lblBookAuthor.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBookAuthor.Location = new System.Drawing.Point(4, 184);
            this.lblBookAuthor.Name = "lblBookAuthor";
            this.lblBookAuthor.Size = new System.Drawing.Size(121, 25);
            this.lblBookAuthor.TabIndex = 10;
            this.lblBookAuthor.Text = "Author";
            this.lblBookAuthor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(0, 222);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(336, 20);
            this.textBox5.TabIndex = 9;
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.BackColor = System.Drawing.Color.Fuchsia;
            this.btnUpdateBook.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateBook.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdateBook.Location = new System.Drawing.Point(0, 260);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(168, 43);
            this.btnUpdateBook.TabIndex = 8;
            this.btnUpdateBook.Text = "Update Book";
            this.btnUpdateBook.UseVisualStyleBackColor = false;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // lblBookPrice
            // 
            this.lblBookPrice.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBookPrice.Location = new System.Drawing.Point(4, 124);
            this.lblBookPrice.Name = "lblBookPrice";
            this.lblBookPrice.Size = new System.Drawing.Size(121, 25);
            this.lblBookPrice.TabIndex = 7;
            this.lblBookPrice.Text = "BookPrice";
            this.lblBookPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(0, 161);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(336, 20);
            this.textBox4.TabIndex = 6;
            // 
            // lblBookIsbn
            // 
            this.lblBookIsbn.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookIsbn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBookIsbn.Location = new System.Drawing.Point(4, 64);
            this.lblBookIsbn.Name = "lblBookIsbn";
            this.lblBookIsbn.Size = new System.Drawing.Size(121, 25);
            this.lblBookIsbn.TabIndex = 5;
            this.lblBookIsbn.Text = "BookISBN";
            this.lblBookIsbn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblBookIsbn.Click += new System.EventHandler(this.lblBookIsbn_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(0, 101);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(336, 20);
            this.textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(0, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(336, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(4, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "BookName";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UpdateBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 450);
            this.Controls.Add(this.pnlEdit);
            this.Controls.Add(this.panel1);
            this.Name = "UpdateBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateBook";
            this.Load += new System.EventHandler(this.UpdateBook_Load);
            this.panel1.ResumeLayout(false);
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.ComboBox cmbook;
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBookIsbn;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblBookPrice;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.Label lblBookAuthor;
        private System.Windows.Forms.TextBox textBox5;
    }
}