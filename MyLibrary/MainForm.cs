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
            //to tez do podswietlania
            dataGridView1.CellFormatting += new DataGridViewCellFormattingEventHandler(dataGridView1_CellFormatting);
            
            DisplayViews();
            
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
            string selectedView = cboView.SelectedItem.ToString();
            UpdateDataGridView(searchPhrase, selectedView);
        }

        public void RefreshDataGridView()
        {
            string selectedView = cboView.SelectedItem.ToString();
            UpdateDataGridView(string.Empty, selectedView);
        }

        private void UpdateDataGridView(string searchPhrase, string selectedView)
        {
            LibraryDAO libraryDAO = new LibraryDAO();
            List<Book> books = new List<Book>();
            if (selectedView == "All my books")
            {
                books = string.IsNullOrEmpty(searchPhrase) ? libraryDAO.GetAllBooks() : libraryDAO.GetBooksBySearchPhrase(searchPhrase);
            }
            else if (selectedView == "To Read")
            {
                books = string.IsNullOrEmpty(searchPhrase) ? libraryDAO.GetToReadBooks() : libraryDAO.GetToReadBooksBySearchPhrase(searchPhrase);
            }
            else if (selectedView == "Already Read")
            {
                books = string.IsNullOrEmpty(searchPhrase) ? libraryDAO.GetAlreadyReadBooks() : libraryDAO.GetAlreadyReadBooksBySearchPhrase(searchPhrase);
            }
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Title", typeof(string));
            dt.Columns.Add("Author", typeof(string));
            //dt.Columns.Add("ISBN", typeof(string));
            //dt.Columns.Add("CoverImageUrl", typeof(string));
            dt.Columns.Add("IsRead", typeof(bool));
            if (books != null)
            {
                foreach (var book in books)
                {
                    dt.Rows.Add(book.Id, book.Title, book.Author, book.IsRead);
                }
            }
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["IsRead"].ReadOnly = true;
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
                    BookDetailsForm bookDetailsForm = new BookDetailsForm(selectedBookId, this);
                    bookDetailsForm.ShowDialog();
                }
            }
        }
        //podswietlenie recordow
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "IsRead")
            {
                if (e.Value != null)
                {
                    bool isRead = (e.Value == DBNull.Value) ? false : (bool)e.Value;
                    if (isRead)
                    {
                        e.CellStyle.BackColor = Color.LightGreen;
                        // set row color
                        dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                }
            }
        }
        private void DisplayViews()
        {
            List<string> views = new List<string> { "All my books", "To Read", "Already Read" };
            cboView.DataSource = views;
            string selectedView = cboView.SelectedItem.ToString();
        }
        private void cboView_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectedView = cboView.SelectedItem.ToString();
            string searchPhrase = txtSearch.Text;
            UpdateDataGridView(searchPhrase, selectedView);
        }
        
    }
}
