using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLibrary
{
    public partial class AddBook : Form
    {
        private MainForm _mainForm;
        private Book book;
        public AddBook(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
        }
        private async void btnSearchISBN_Click(object sender, EventArgs e)
        {
            string ISBN = txtISBN.Text;
            book = await Book.GetBookByISBN(ISBN);
            if (book != null)
            {
                lblTitle.Text = book.Title;
                lblAuthor.Text = book.Author;
                
                btnSave.Enabled = true;
            }
            else
            {
                MessageBox.Show("Book not found or an error occurred.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            LibraryDAO libraryDAO = new LibraryDAO();
            libraryDAO.AddBook(book);

            _mainForm.RefreshDataGridView();

            Dispose();
            MessageBox.Show("Book added to Library");
        }
    }
}
