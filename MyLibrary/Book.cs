using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLibrary
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

        public static async Task<Book> GetBookByISBN(string ISBN)
        {
            Book book = new Book();
            using (var client = new HttpClient())
            {
                // set the API endpoint
                string url = "https://www.googleapis.com/books/v1/volumes?q=isbn:" + ISBN;

                // send a GET request to the API endpoint
                HttpResponseMessage response;
                try
                {
                    response = await client.GetAsync(url);
                }
                catch (HttpRequestException ex)
                {
                    // handle exception when there is an error with the API call
                    // for example, log the error or show a message to the user
                    return null;
                }

                // read the JSON response as a string
                var json = await response.Content.ReadAsStringAsync();

                // deserialize the JSON string into a dynamic object
                var bookData = JsonConvert.DeserializeObject<dynamic>(json);
                if (bookData.totalItems == 0)
                {
                    // handle case when ISBN number is not found
                    // for example, log the error or show a message to the user
                    return null;
                }
                // access the data you need, for example the title of the book
                book.Title = bookData.items[0].volumeInfo.title;
                book.Author = bookData.items[0].volumeInfo.authors[0];
                book.ISBN = ISBN;
            }
            return book;
        }
    }
}
