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
        
        public AddBook()
        {
            InitializeComponent();

        }
        async void ISBNSearch(string isbn)
        {
            //create a HttpClient
            using (var client = new HttpClient())
            {
                //set the API endpoint
                string url = "https://www.googleapis.com/books/v1/volumes?q=isbn:" + isbn;

                //send a GET request to the API endpoint
                var response = await client.GetAsync(url);

                //read the JSON response as a string
                var json = await response.Content.ReadAsStringAsync();

                //deserialize the JSON string into a dynamic object
                var bookData = JsonConvert.DeserializeObject<dynamic>(json);

                //access the data you need, for example the title of the book
                lblTitle.Text = bookData.items[0].volumeInfo.title;
                lblAuthor.Text = bookData.items[0].volumeInfo.authors[0];
            }
        }

        private void btnSearchISBN_Click(object sender, EventArgs e)
        {
            ISBNSearch(txtISBN.Text);

            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Book book = new Book
            {
                Title = lblTitle.Text,
                Author = lblAuthor.Text,
                ISBN = txtISBN.Text
            };

            LibraryDAO libraryDAO = new LibraryDAO();
            libraryDAO.AddBook(book);
            
            Dispose();
            MessageBox.Show("Book added to Library");
        }
    }
}
