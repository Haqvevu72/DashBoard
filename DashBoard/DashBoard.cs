using DashBoard.Contexts;
using DashBoard.Entities;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Security.Principal;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace DashBoard
{
    public partial class DashBoard : Form
    {
        static LibraryDb libraryDb = new LibraryDb();
        int studentcount = libraryDb.Students.Count();
        int bookcount = libraryDb.Books.Count();
        int teachercount = libraryDb.Teachers.Count();
        public DashBoard()
        {
            InitializeComponent();
            lbl_bookcount.Text = bookcount.ToString();

            lbl_teachercount.Text = teachercount.ToString();

            lbl_studentcount.Text = studentcount.ToString();

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            if (studentcount != libraryDb.Students.Count() || bookcount != libraryDb.Books.Count() || teachercount != libraryDb.Teachers.Count())
            {
                lbl_bookcount.Text = libraryDb.Books.Count().ToString();
                lbl_teachercount.Text = libraryDb.Teachers.Count().ToString();
                lbl_studentcount.Text = libraryDb.Students.Count().ToString();

                studentcount = libraryDb.Students.Count();
                bookcount = libraryDb.Books.Count();
                teachercount = libraryDb.Teachers.Count();
            }
            else { MessageBox.Show("You are updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void btn_addbook_Click(object sender, EventArgs e)
        {
            AddBook addBook = new AddBook();
            addBook.ShowDialog();
        }

        private void btn_addstudent_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.ShowDialog();
        }

        private void btn_addteacher_Click(object sender, EventArgs e)
        {
            AddTeacher addTeacher = new AddTeacher();
            addTeacher.ShowDialog();
        }
    }
}