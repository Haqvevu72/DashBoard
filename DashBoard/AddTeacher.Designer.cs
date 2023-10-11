namespace DashBoard
{
    partial class AddTeacher
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
            btn_addstudent = new Button();
            button1 = new Button();
            txtbox_iddep = new TextBox();
            label2 = new Label();
            txtbox_surname = new TextBox();
            label1 = new Label();
            txtbox_name = new TextBox();
            Book_Name = new Label();
            txtbox_id = new TextBox();
            Id = new Label();
            SuspendLayout();
            // 
            // btn_addstudent
            // 
            btn_addstudent.BackColor = Color.LightSalmon;
            btn_addstudent.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_addstudent.Location = new Point(545, 319);
            btn_addstudent.Name = "btn_addstudent";
            btn_addstudent.Size = new Size(75, 31);
            btn_addstudent.TabIndex = 53;
            btn_addstudent.Text = "Add";
            btn_addstudent.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSalmon;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(378, 199);
            button1.Name = "button1";
            button1.Size = new Size(75, 31);
            button1.TabIndex = 64;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtbox_iddep
            // 
            txtbox_iddep.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtbox_iddep.Location = new Point(129, 157);
            txtbox_iddep.Name = "txtbox_iddep";
            txtbox_iddep.Size = new Size(324, 27);
            txtbox_iddep.TabIndex = 61;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(5, 160);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 60;
            label2.Text = "Department ID:";
            // 
            // txtbox_surname
            // 
            txtbox_surname.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtbox_surname.Location = new Point(129, 111);
            txtbox_surname.Name = "txtbox_surname";
            txtbox_surname.Size = new Size(324, 27);
            txtbox_surname.TabIndex = 59;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(5, 114);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 58;
            label1.Text = "LastName";
            // 
            // txtbox_name
            // 
            txtbox_name.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtbox_name.Location = new Point(129, 69);
            txtbox_name.Name = "txtbox_name";
            txtbox_name.Size = new Size(324, 27);
            txtbox_name.TabIndex = 57;
            // 
            // Book_Name
            // 
            Book_Name.AutoSize = true;
            Book_Name.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Book_Name.ForeColor = Color.SaddleBrown;
            Book_Name.Location = new Point(5, 72);
            Book_Name.Name = "Book_Name";
            Book_Name.Size = new Size(86, 20);
            Book_Name.TabIndex = 56;
            Book_Name.Text = "FirstName:";
            // 
            // txtbox_id
            // 
            txtbox_id.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtbox_id.Location = new Point(129, 31);
            txtbox_id.Name = "txtbox_id";
            txtbox_id.Size = new Size(324, 27);
            txtbox_id.TabIndex = 55;
            // 
            // Id
            // 
            Id.AutoSize = true;
            Id.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Id.ForeColor = Color.SaddleBrown;
            Id.Location = new Point(5, 34);
            Id.Name = "Id";
            Id.Size = new Size(29, 20);
            Id.TabIndex = 54;
            Id.Text = "ID:";
            // 
            // AddTeacher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(481, 255);
            Controls.Add(button1);
            Controls.Add(txtbox_iddep);
            Controls.Add(label2);
            Controls.Add(txtbox_surname);
            Controls.Add(label1);
            Controls.Add(txtbox_name);
            Controls.Add(Book_Name);
            Controls.Add(txtbox_id);
            Controls.Add(Id);
            Controls.Add(btn_addstudent);
            Name = "AddTeacher";
            Text = "AddTeacher";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_addstudent;
        private Button button1;
        private TextBox txtbox_term;
        private Label label6;
        private TextBox txtbox_iddep;
        private Label label2;
        private TextBox txtbox_surname;
        private Label label1;
        private TextBox txtbox_name;
        private Label Book_Name;
        private TextBox txtbox_id;
        private Label Id;
    }
}