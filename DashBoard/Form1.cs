using DashBoard.Contexts;

namespace DashBoard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LibraryDb libraryDb = new LibraryDb();
            libraryDb.Book.Add(new Entities.Book())
        }
    }
}