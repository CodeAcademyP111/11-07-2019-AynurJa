namespace Library
{
    partial class DeleteBook
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
            this.btnCreateBook = new System.Windows.Forms.Button();
            this.cmbook = new System.Windows.Forms.ComboBox();
            this.lblBookName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreateBook
            // 
            this.btnCreateBook.BackColor = System.Drawing.Color.Red;
            this.btnCreateBook.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateBook.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCreateBook.Location = new System.Drawing.Point(12, 143);
            this.btnCreateBook.Name = "btnCreateBook";
            this.btnCreateBook.Size = new System.Drawing.Size(216, 52);
            this.btnCreateBook.TabIndex = 6;
            this.btnCreateBook.Text = "Delete Book";
            this.btnCreateBook.UseVisualStyleBackColor = false;
            this.btnCreateBook.Click += new System.EventHandler(this.btnCreateBook_Click);
            // 
            // cmbook
            // 
            this.cmbook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbook.FormattingEnabled = true;
            this.cmbook.Location = new System.Drawing.Point(12, 49);
            this.cmbook.Name = "cmbook";
            this.cmbook.Size = new System.Drawing.Size(251, 21);
            this.cmbook.TabIndex = 7;
            // 
            // lblBookName
            // 
            this.lblBookName.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookName.Location = new System.Drawing.Point(12, 9);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(121, 25);
            this.lblBookName.TabIndex = 8;
            this.lblBookName.Text = "Select Book";
            this.lblBookName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DeleteBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 276);
            this.Controls.Add(this.lblBookName);
            this.Controls.Add(this.cmbook);
            this.Controls.Add(this.btnCreateBook);
            this.Name = "DeleteBook";
            this.Text = "DeleteBook";
            this.Load += new System.EventHandler(this.DeleteBook_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateBook;
        private System.Windows.Forms.ComboBox cmbook;
        private System.Windows.Forms.Label lblBookName;
    }
}