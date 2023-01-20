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
        private LibraryDAO _libraryDAO;
        public AddBook(MainForm mainForm)
        {
            _mainForm = mainForm;
            _libraryDAO = new LibraryDAO();
            InitializeComponent();
            picBox1.Load(_libraryDAO.defaultImgUrl);
        }
        private async void btnSearchISBN_Click(object sender, EventArgs e)
        {
            string ISBN = txtISBN.Text;
            if (await _libraryDAO.PopulateTextboxesByISBNAsync(ISBN, txtAddTitle, txtAddAuthor, txtAddImgUrl, checkIsRead))
            {
                picBox1.Load(txtAddImgUrl.Text);
                btnSave.Enabled = true;
            }
            else
            {
                MessageBox.Show("Book not found or an error occurred.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.Title = txtAddTitle.Text;
            book.Author = txtAddAuthor.Text;
            book.ISBN = txtISBN.Text;
            book.CoverImageUrl = txtAddImgUrl.Text;
            book.IsRead = checkIsRead.Checked;

            _libraryDAO.AddBook(book);
            _mainForm.RefreshDataGridView();
            Dispose();
            MessageBox.Show("Book added to Library");
        }

        private void btnImgRef_Click(object sender, EventArgs e)
        {
            if (_libraryDAO.IsValidUrl(txtAddImgUrl.Text))
            {
                picBox1.Load(txtAddImgUrl.Text);
            }
            else
            {
                MessageBox.Show("Image URL not valid");
                txtAddImgUrl.Text = picBox1.ImageLocation;
            }

        }
    }
}
