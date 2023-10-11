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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void btn_addstudent_Click(object sender, EventArgs e)
        {
            LibraryDb library = new LibraryDb();
            int Id = Convert.ToInt32(txtbox_id.Text.ToString());
            string FirstName = txtbox_name.Text.ToString();
            string LastName = txtbox_surname.Text.ToString();
            int Id_Group = Convert.ToInt32(txtbox_idgroup.Text.ToString());
            int Term = Convert.ToInt32(txtbox_term.Text.ToString());

            Student student = new Student() {Id=Id,FirstName=FirstName,LastName=LastName,Id_Group=Id_Group,Term=Term};
            library.Students.Add(student);
            library.SaveChanges();

            DashBoard.lbl_studentcount.Text = library.Students.Count().ToString();

            MessageBox.Show("Book is successfully added !", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();

        }
    }
}
