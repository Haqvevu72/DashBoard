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
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void btn_addbook_Click(object sender, EventArgs e)
        {
            LibraryDb library = new LibraryDb();
            int id = Convert.ToInt32(txtbox_id.Text.ToString());
            string Name = txtbox_name.Text.ToString();
            int pages = Convert.ToInt32(txtbox_pages.Text.ToString());
            int pressyear = Convert.ToInt32(txtbox_pyear.Text.ToString());
            int Id_tehemes = Convert.ToInt32(txtbox_idthemes.Text.ToString());
            int Id_author = Convert.ToInt32(txtbox_idauthor.Text.ToString());
            int id_categories = Convert.ToInt32(txtbox_categoryid.Text.ToString());
            int id_press = Convert.ToInt32(txtbox_idpress.Text.ToString());
            string comment = txtbox_comment.Text.ToString();
            int quantity = Convert.ToInt32(txtbox_quantity.Text.ToString());

            Book newbook = new Book() { Id = id, Name = Name, Pages = pages, YearPress = pressyear, Id_Themes = Id_tehemes, Id_Author = Id_author, Id_Category = id_categories, Id_Press = id_press, Comment = comment, Quantity = quantity };


            library.Books.Add(newbook);
            library.SaveChanges();
         }
    }
}
