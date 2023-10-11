namespace DashBoard
{
    partial class DashBoard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label1 = new Label();
            pnl_book = new Panel();
            lbl_bookcount = new Label();
            lbl_book = new Label();
            panel1 = new Panel();
            lbl_studentcount = new Label();
            lbl_student = new Label();
            panel2 = new Panel();
            lbl_teachercount = new Label();
            lbl_teacher = new Label();
            btn_addteacher = new Button();
            btn_addstudent = new Button();
            btn_addbook = new Button();
            pnl_book.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(10, 10);
            label1.Name = "label1";
            label1.Size = new Size(138, 32);
            label1.TabIndex = 2;
            label1.Text = "Dashboard";
            // 
            // pnl_book
            // 
            pnl_book.BackColor = SystemColors.HighlightText;
            pnl_book.Controls.Add(lbl_bookcount);
            pnl_book.Controls.Add(lbl_book);
            pnl_book.Location = new Point(183, 12);
            pnl_book.Name = "pnl_book";
            pnl_book.Size = new Size(208, 55);
            pnl_book.TabIndex = 3;
            // 
            // lbl_bookcount
            // 
            lbl_bookcount.AutoSize = true;
            lbl_bookcount.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_bookcount.Location = new Point(90, 23);
            lbl_bookcount.Name = "lbl_bookcount";
            lbl_bookcount.Padding = new Padding(0, 10, 0, 0);
            lbl_bookcount.Size = new Size(18, 30);
            lbl_bookcount.TabIndex = 1;
            lbl_bookcount.Text = "0";
            // 
            // lbl_book
            // 
            lbl_book.AutoSize = true;
            lbl_book.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_book.ForeColor = Color.MediumSeaGreen;
            lbl_book.Location = new Point(48, -3);
            lbl_book.Name = "lbl_book";
            lbl_book.Size = new Size(103, 21);
            lbl_book.TabIndex = 0;
            lbl_book.Text = "Book Count:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HighlightText;
            panel1.Controls.Add(lbl_studentcount);
            panel1.Controls.Add(lbl_student);
            panel1.Location = new Point(432, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(208, 55);
            panel1.TabIndex = 4;
            // 
            // lbl_studentcount
            // 
            lbl_studentcount.AutoSize = true;
            lbl_studentcount.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_studentcount.Location = new Point(91, 23);
            lbl_studentcount.Name = "lbl_studentcount";
            lbl_studentcount.Padding = new Padding(0, 10, 0, 0);
            lbl_studentcount.Size = new Size(18, 30);
            lbl_studentcount.TabIndex = 1;
            lbl_studentcount.Text = "0";
            // 
            // lbl_student
            // 
            lbl_student.AutoSize = true;
            lbl_student.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_student.ForeColor = Color.Tomato;
            lbl_student.Location = new Point(50, -3);
            lbl_student.Name = "lbl_student";
            lbl_student.Size = new Size(124, 21);
            lbl_student.TabIndex = 0;
            lbl_student.Text = "Student Count:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HighlightText;
            panel2.Controls.Add(lbl_teachercount);
            panel2.Controls.Add(lbl_teacher);
            panel2.Location = new Point(687, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(208, 55);
            panel2.TabIndex = 5;
            // 
            // lbl_teachercount
            // 
            lbl_teachercount.AutoSize = true;
            lbl_teachercount.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_teachercount.Location = new Point(97, 21);
            lbl_teachercount.Name = "lbl_teachercount";
            lbl_teachercount.Padding = new Padding(0, 10, 0, 0);
            lbl_teachercount.Size = new Size(18, 30);
            lbl_teachercount.TabIndex = 1;
            lbl_teachercount.Text = "0";
            // 
            // lbl_teacher
            // 
            lbl_teacher.AutoSize = true;
            lbl_teacher.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_teacher.ForeColor = Color.MediumTurquoise;
            lbl_teacher.Location = new Point(51, -5);
            lbl_teacher.Name = "lbl_teacher";
            lbl_teacher.Size = new Size(123, 21);
            lbl_teacher.TabIndex = 0;
            lbl_teacher.Text = "Teacher Count:";
            // 
            // btn_addteacher
            // 
            btn_addteacher.BackColor = Color.OrangeRed;
            btn_addteacher.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_addteacher.ForeColor = Color.MediumTurquoise;
            btn_addteacher.Location = new Point(338, 140);
            btn_addteacher.Name = "btn_addteacher";
            btn_addteacher.Size = new Size(222, 50);
            btn_addteacher.TabIndex = 7;
            btn_addteacher.Text = "Add Teacher";
            btn_addteacher.UseVisualStyleBackColor = false;
            // 
            // btn_addstudent
            // 
            btn_addstudent.BackColor = Color.Turquoise;
            btn_addstudent.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_addstudent.ForeColor = Color.Tomato;
            btn_addstudent.Location = new Point(338, 248);
            btn_addstudent.Name = "btn_addstudent";
            btn_addstudent.Size = new Size(222, 50);
            btn_addstudent.TabIndex = 8;
            btn_addstudent.Text = "Add Student";
            btn_addstudent.UseVisualStyleBackColor = false;
            btn_addstudent.Click += btn_addstudent_Click;
            // 
            // btn_addbook
            // 
            btn_addbook.BackColor = Color.PeachPuff;
            btn_addbook.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_addbook.ForeColor = Color.MediumSeaGreen;
            btn_addbook.Location = new Point(338, 363);
            btn_addbook.Name = "btn_addbook";
            btn_addbook.Size = new Size(222, 50);
            btn_addbook.TabIndex = 9;
            btn_addbook.Text = "Add Book";
            btn_addbook.UseVisualStyleBackColor = false;
            btn_addbook.Click += btn_addbook_Click;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(6F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(929, 480);
            Controls.Add(btn_addbook);
            Controls.Add(btn_addstudent);
            Controls.Add(btn_addteacher);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pnl_book);
            Controls.Add(label1);
            Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "DashBoard";
            Text = "Library";
            pnl_book.ResumeLayout(false);
            pnl_book.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private Label label1;
        private Panel pnl_book;
        private Label lbl_book;
        private Panel panel1;
        private Label lbl_student;
        private Panel panel2;
        private Label lbl_teachercount;
        private Label lbl_teacher;
        private Button btn_addteacher;
        private Button btn_addstudent;
        private Button btn_addbook;
        public static Label lbl_bookcount;
        public static Label lbl_studentcount;
    }
}