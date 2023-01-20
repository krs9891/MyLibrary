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
        private LibraryDAO _libraryDAO;
        public BookDetailsForm(int selectedBookId, MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;

            _libraryDAO = new LibraryDAO();
            Book book = _libraryDAO.GetBookById(selectedBookId);

            PopulateForm(book);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int bookId = int.Parse(lblDetId.Text);
            //LibraryDAO libraryDAO = new LibraryDAO();
            Book book = _libraryDAO.GetBookById(bookId);

            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected book?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _libraryDAO.DeleteBook(book);
                _mainForm.RefreshDataGridView();
                this.Dispose();
            }
        }
        private void BookDetailsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnDetEdit_Click(object sender, EventArgs e)
        {
            AllowEdit(true);
        }

        private void btnCnl_Click(object sender, EventArgs e)
        {
            AllowEdit(false);

            LibraryDAO libraryDAO = new LibraryDAO();
            int selectedBookId = int.Parse(lblDetId.Text);
            Book book = libraryDAO.GetBookById(selectedBookId);
            PopulateForm(book);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to modify the book?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int bookId = int.Parse(lblDetId.Text);
                Book book = new Book();
                book.Id = bookId;
                book.Title = txtDetTitle.Text;
                book.Author = txtDetAuthor.Text;
                book.ISBN = txtDetISBN.Text;
                book.CoverImageUrl = txtDetImgUrl.Text;
                book.IsRead = checkDetIsRead.Checked;

                LibraryDAO libraryDAO = new LibraryDAO();
                libraryDAO.UpdateBook(book);

                _mainForm.RefreshDataGridView();

                AllowEdit(false);
            }
        }

        void AllowEdit(bool enable)
        {
            txtDetISBN.Enabled = enable;
            txtDetTitle.Enabled = enable;
            txtDetAuthor.Enabled = enable;
            txtDetImgUrl.Enabled = enable;
            btnDetLoadImg.Enabled = enable;
            checkDetIsRead.Enabled = enable;

            btnApply.Enabled = enable;
            btnDelete.Enabled = !enable;
            btnCnl.Enabled = enable;
            btnClose.Enabled = !enable;
        }

        private void PopulateForm(Book book)
        {
            lblDetId.Text = book.Id.ToString();
            txtDetISBN.Text = book.ISBN;
            txtDetTitle.Text = book.Title;
            txtDetAuthor.Text = book.Author;
            txtDetImgUrl.Text = book.CoverImageUrl;
            checkDetIsRead.Checked = book.IsRead;
            picBox2.Load(book.CoverImageUrl);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnDetLoadImg_Click(object sender, EventArgs e)
        {
            if (_libraryDAO.IsValidUrl(txtDetImgUrl.Text))
            {
                picBox2.Load(txtDetImgUrl.Text);
            }
            else
            {
                MessageBox.Show("Image URL is not valid");
                txtDetImgUrl.Text = picBox2.ImageLocation;
            }
        }
    }
}
