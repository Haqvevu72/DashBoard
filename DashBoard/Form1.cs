using DashBoard.Contexts;
using DashBoard.Entities;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Security.Principal;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace DashBoard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LibraryDb libraryDb = new LibraryDb();
            lbl_bookcount.Text = libraryDb.Book.Count().ToString();
            lbl_teachercount.Text = libraryDb.Teachers.Count().ToString();
            lbl_studentcount.Text = libraryDb.Students.Count().ToString();
        }

    }
}