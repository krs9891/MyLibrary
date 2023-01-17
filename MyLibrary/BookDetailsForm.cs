using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLibrary
{
    public partial class BookDetailsForm : Form
    {
        private MainForm _mainForm;
        public BookDetailsForm(int selectedBookId, MainForm mainForm)
        {
            InitializeComponent();
            LibraryDAO libraryDAO = new LibraryDAO();
            Book book = libraryDAO.GetBookById(selectedBookId);
            lblDetId.Text = book.Id.ToString();
            lblDetISBN.Text = book.ISBN;
            lblDetTitle.Text = book.Title;
            lblDetAuthor.Text = book.Author;
            picBox2.Load(book.CoverImageUrl);
            _mainForm = mainForm;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int bookId = int.Parse(lblDetId.Text);
            LibraryDAO libraryDAO = new LibraryDAO();
            Book book = libraryDAO.GetBookById(bookId);

            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected book?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                libraryDAO.DeleteBook(book);
                _mainForm.RefreshDataGridView();
                this.Dispose();
            }
        }
    }
}
