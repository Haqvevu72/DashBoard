namespace DashBoard
{
    partial class AddBook
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
            Id = new Label();
            txtbox_id = new TextBox();
            Book_Name = new Label();
            txtbox_name = new TextBox();
            label1 = new Label();
            txtbox_pages = new TextBox();
            label2 = new Label();
            txtbox_pyear = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtbox_idthemes = new TextBox();
            txtbox_categoryid = new TextBox();
            txtbox_idauthor = new TextBox();
            txtbox_idpress = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtbox_comment = new TextBox();
            txtbox_quantity = new TextBox();
            btn_addbook = new Button();
            SuspendLayout();
            // 
            // Id
            // 
            Id.AutoSize = true;
            Id.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Id.ForeColor = Color.DarkCyan;
            Id.Location = new Point(37, 27);
            Id.Name = "Id";
            Id.Size = new Size(29, 20);
            Id.TabIndex = 0;
            Id.Text = "ID:";
            // 
            // txtbox_id
            // 
            txtbox_id.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtbox_id.Location = new Point(108, 24);
            txtbox_id.Name = "txtbox_id";
            txtbox_id.Size = new Size(324, 27);
            txtbox_id.TabIndex = 1;
            // 
            // Book_Name
            // 
            Book_Name.AutoSize = true;
            Book_Name.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Book_Name.ForeColor = Color.DarkCyan;
            Book_Name.Location = new Point(30, 65);
            Book_Name.Name = "Book_Name";
            Book_Name.Size = new Size(55, 20);
            Book_Name.TabIndex = 2;
            Book_Name.Text = "Name:";
            // 
            // txtbox_name
            // 
            txtbox_name.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtbox_name.Location = new Point(108, 62);
            txtbox_name.Name = "txtbox_name";
            txtbox_name.Size = new Size(324, 27);
            txtbox_name.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(31, 107);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 4;
            label1.Text = "Pages:";
            // 
            // txtbox_pages
            // 
            txtbox_pages.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtbox_pages.Location = new Point(108, 104);
            txtbox_pages.Name = "txtbox_pages";
            txtbox_pages.Size = new Size(324, 27);
            txtbox_pages.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(20, 150);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 6;
            label2.Text = "Press Year:";
            // 
            // txtbox_pyear
            // 
            txtbox_pyear.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtbox_pyear.Location = new Point(108, 150);
            txtbox_pyear.Name = "txtbox_pyear";
            txtbox_pyear.Size = new Size(324, 27);
            txtbox_pyear.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkCyan;
            label3.Location = new Point(23, 312);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 8;
            label3.Text = "Id_Press:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkCyan;
            label4.Location = new Point(14, 274);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 9;
            label4.Text = "Id_Author:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkCyan;
            label5.Location = new Point(11, 226);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 10;
            label5.Text = "Id_Category:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkCyan;
            label6.Location = new Point(20, 191);
            label6.Name = "label6";
            label6.Size = new Size(88, 20);
            label6.TabIndex = 11;
            label6.Text = "Id_Themes:";
            // 
            // txtbox_idthemes
            // 
            txtbox_idthemes.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtbox_idthemes.Location = new Point(108, 191);
            txtbox_idthemes.Name = "txtbox_idthemes";
            txtbox_idthemes.Size = new Size(324, 27);
            txtbox_idthemes.TabIndex = 12;
            // 
            // txtbox_categoryid
            // 
            txtbox_categoryid.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtbox_categoryid.Location = new Point(108, 227);
            txtbox_categoryid.Name = "txtbox_categoryid";
            txtbox_categoryid.Size = new Size(324, 27);
            txtbox_categoryid.TabIndex = 13;
            // 
            // txtbox_idauthor
            // 
            txtbox_idauthor.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtbox_idauthor.Location = new Point(108, 271);
            txtbox_idauthor.Name = "txtbox_idauthor";
            txtbox_idauthor.Size = new Size(324, 27);
            txtbox_idauthor.TabIndex = 14;
            // 
            // txtbox_idpress
            // 
            txtbox_idpress.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtbox_idpress.Location = new Point(108, 313);
            txtbox_idpress.Name = "txtbox_idpress";
            txtbox_idpress.Size = new Size(324, 27);
            txtbox_idpress.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkCyan;
            label7.Location = new Point(14, 359);
            label7.Name = "label7";
            label7.Size = new Size(82, 20);
            label7.TabIndex = 16;
            label7.Text = "Comment:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkCyan;
            label8.Location = new Point(22, 394);
            label8.Name = "label8";
            label8.Size = new Size(74, 20);
            label8.TabIndex = 17;
            label8.Text = "Quantity:";
            // 
            // txtbox_comment
            // 
            txtbox_comment.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtbox_comment.Location = new Point(108, 356);
            txtbox_comment.Name = "txtbox_comment";
            txtbox_comment.Size = new Size(324, 27);
            txtbox_comment.TabIndex = 19;
            // 
            // txtbox_quantity
            // 
            txtbox_quantity.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtbox_quantity.Location = new Point(108, 394);
            txtbox_quantity.Name = "txtbox_quantity";
            txtbox_quantity.Size = new Size(324, 27);
            txtbox_quantity.TabIndex = 20;
            // 
            // btn_addbook
            // 
            btn_addbook.BackColor = Color.LightSalmon;
            btn_addbook.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_addbook.Location = new Point(357, 426);
            btn_addbook.Name = "btn_addbook";
            btn_addbook.Size = new Size(75, 31);
            btn_addbook.TabIndex = 21;
            btn_addbook.Text = "Add";
            btn_addbook.UseVisualStyleBackColor = false;
            btn_addbook.Click += btn_addbook_Click;
            // 
            // AddBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(481, 469);
            Controls.Add(btn_addbook);
            Controls.Add(txtbox_quantity);
            Controls.Add(txtbox_comment);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtbox_idpress);
            Controls.Add(txtbox_idauthor);
            Controls.Add(txtbox_categoryid);
            Controls.Add(txtbox_idthemes);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtbox_pyear);
            Controls.Add(label2);
            Controls.Add(txtbox_pages);
            Controls.Add(label1);
            Controls.Add(txtbox_name);
            Controls.Add(Book_Name);
            Controls.Add(txtbox_id);
            Controls.Add(Id);
            ForeColor = Color.SaddleBrown;
            Name = "AddBook";
            Text = "AddBook";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Id;
        private TextBox txtbox_id;
        private Label Book_Name;
        private TextBox txtbox_name;
        private Label label1;
        private TextBox txtbox_pages;
        private Label label2;
        private TextBox txtbox_pyear;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtbox_idthemes;
        private TextBox txtbox_categoryid;
        private TextBox txtbox_idauthor;
        private TextBox txtbox_idpress;
        private Label label7;
        private Label label8;
        private TextBox txtbox_comment;
        private TextBox txtbox_quantity;
        private Button btn_addbook;
    }
}