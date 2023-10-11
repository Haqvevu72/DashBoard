namespace DashBoard
{
    partial class AddStudent
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
            label6 = new Label();
            txtbox_idgroup = new TextBox();
            label2 = new Label();
            txtbox_surname = new TextBox();
            label1 = new Label();
            txtbox_name = new TextBox();
            Book_Name = new Label();
            txtbox_id = new TextBox();
            Id = new Label();
            txtbox_term = new TextBox();
            SuspendLayout();
            // 
            // btn_addstudent
            // 
            btn_addstudent.BackColor = Color.LightSalmon;
            btn_addstudent.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_addstudent.Location = new Point(376, 236);
            btn_addstudent.Name = "btn_addstudent";
            btn_addstudent.Size = new Size(75, 31);
            btn_addstudent.TabIndex = 42;
            btn_addstudent.Text = "Add";
            btn_addstudent.UseVisualStyleBackColor = false;
            btn_addstudent.Click += btn_addstudent_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.SaddleBrown;
            label6.Location = new Point(13, 185);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 33;
            label6.Text = "Term:";
            // 
            // txtbox_idgroup
            // 
            txtbox_idgroup.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtbox_idgroup.Location = new Point(127, 144);
            txtbox_idgroup.Name = "txtbox_idgroup";
            txtbox_idgroup.Size = new Size(324, 27);
            txtbox_idgroup.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(13, 144);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 28;
            label2.Text = "Group ID:";
            // 
            // txtbox_surname
            // 
            txtbox_surname.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtbox_surname.Location = new Point(127, 98);
            txtbox_surname.Name = "txtbox_surname";
            txtbox_surname.Size = new Size(324, 27);
            txtbox_surname.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(13, 98);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 26;
            label1.Text = "LastName";
            // 
            // txtbox_name
            // 
            txtbox_name.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtbox_name.Location = new Point(127, 56);
            txtbox_name.Name = "txtbox_name";
            txtbox_name.Size = new Size(324, 27);
            txtbox_name.TabIndex = 25;
            // 
            // Book_Name
            // 
            Book_Name.AutoSize = true;
            Book_Name.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Book_Name.ForeColor = Color.SaddleBrown;
            Book_Name.Location = new Point(12, 59);
            Book_Name.Name = "Book_Name";
            Book_Name.Size = new Size(86, 20);
            Book_Name.TabIndex = 24;
            Book_Name.Text = "FirstName:";
            // 
            // txtbox_id
            // 
            txtbox_id.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtbox_id.Location = new Point(127, 18);
            txtbox_id.Name = "txtbox_id";
            txtbox_id.Size = new Size(324, 27);
            txtbox_id.TabIndex = 23;
            // 
            // Id
            // 
            Id.AutoSize = true;
            Id.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Id.ForeColor = Color.SaddleBrown;
            Id.Location = new Point(12, 21);
            Id.Name = "Id";
            Id.Size = new Size(29, 20);
            Id.TabIndex = 22;
            Id.Text = "ID:";
            // 
            // txtbox_term
            // 
            txtbox_term.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtbox_term.Location = new Point(127, 185);
            txtbox_term.Name = "txtbox_term";
            txtbox_term.Size = new Size(324, 27);
            txtbox_term.TabIndex = 34;
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(481, 286);
            Controls.Add(btn_addstudent);
            Controls.Add(txtbox_term);
            Controls.Add(label6);
            Controls.Add(txtbox_idgroup);
            Controls.Add(label2);
            Controls.Add(txtbox_surname);
            Controls.Add(label1);
            Controls.Add(txtbox_name);
            Controls.Add(Book_Name);
            Controls.Add(txtbox_id);
            Controls.Add(Id);
            Name = "AddStudent";
            Text = "AddStudent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_addstudent;
        private Label label6;
        private TextBox txtbox_idgroup;
        private Label label2;
        private TextBox txtbox_surname;
        private Label label1;
        private TextBox txtbox_name;
        private Label Book_Name;
        private TextBox txtbox_id;
        private Label Id;
        private TextBox txtbox_term;
    }
}