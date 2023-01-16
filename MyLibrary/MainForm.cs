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
    public partial class MainForm : Form
    {
        private DataGridView dataGridView;
        public MainForm()
        {
            InitializeComponent();
            dataGridView = this.dataGridView1;
            RefreshDataGridView();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AddBook addBook = new AddBook(this);
            addBook.Show();
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            string searchPhrase = txtSearch.Text;
            UpdateDataGridView(searchPhrase);
        }

        public void RefreshDataGridView()
        {
            UpdateDataGridView(string.Empty);
        }

        private void UpdateDataGridView(string searchPhrase)
        {
            LibraryDAO libraryDAO = new LibraryDAO();
            List<Book> books = string.IsNullOrEmpty(searchPhrase) ? libraryDAO.GetAllBooks() : libraryDAO.GetBooksBySearchPhrase(searchPhrase);
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Title", typeof(string));
            dt.Columns.Add("Author", typeof(string));
            dt.Columns.Add("ISBN", typeof(string));
            foreach (var book in books)
            {
                dt.Rows.Add(book.Id, book.Title, book.Author, book.ISBN);
            }
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                // Make sure the user double-clicked a row (and not a column header)
                if (e.RowIndex >= 0)
                {
                    // Get the selected book's ID
                    int selectedBookId = (int)dataGridView1.Rows[e.RowIndex].Cells["Id"].Value;

                    // Open the BookDetails form and pass the selected book's ID
                    BookDetailsForm bookDetailsForm = new BookDetailsForm(selectedBookId);
                    bookDetailsForm.ShowDialog();
                }
            }
        }
    }


}
