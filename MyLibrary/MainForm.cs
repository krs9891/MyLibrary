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

        public void RefreshDataGridView()
        {
            LibraryDAO libraryDAO = new LibraryDAO();
            List<Book> books = libraryDAO.GetAllBooks();
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Title", typeof(string));
            dt.Columns.Add("Author", typeof(string));
            dt.Columns.Add("ISBN", typeof(string));
            foreach (var book in books)
            {
                dt.Rows.Add(book.Id, book.Title, book.Author, book.ISBN);
            }
            dataGridView.DataSource = dt;
        }
    }


}
