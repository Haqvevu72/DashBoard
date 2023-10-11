using DashBoard.Contexts;
using DashBoard.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashBoard
{
    public partial class AddTeacher : Form
    {
        public AddTeacher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LibraryDb library = new LibraryDb();
            int Id = Convert.ToInt32(txtbox_id.Text.ToString());
            string FirstName = txtbox_name.Text.ToString();
            string LastName = txtbox_surname.Text.ToString();
            int Id_Dep = Convert.ToInt32(txtbox_iddep.Text.ToString());
            

            Teacher new_teacher = new Teacher() { Id = Id, FirstName = FirstName, LastName = LastName,Id_Dep=Id_Dep};
            library.Teachers.Add(new_teacher);
            library.SaveChanges();

            DashBoard.lbl_teachercount.Text = library.Teachers.Count().ToString();

            MessageBox.Show("Teacher is successfully added !", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }
    }
}
