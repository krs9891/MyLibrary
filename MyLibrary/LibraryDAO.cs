using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLibrary
{
    public class LibraryDAO
    {
        public string defaultImgUrl = "https://books.google.pl/googlebooks/images/no_cover_thumb.gif";
        string connectionString = "Server=tcp:wsb-projects.database.windows.net,1433;Initial Catalog=MyLibrary;Persist Security Info=False;User ID=admin1;Password=zaq1@WSX;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        
        public async Task<bool> PopulateTextboxesByISBNAsync(string ISBN, TextBox txtAddTitle, TextBox txtAddAuthor, TextBox txtAddImgUrl, CheckBox checkIsRead)
        {
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
                    return false;
                }

                // read the JSON response as a string
                var json = await response.Content.ReadAsStringAsync();

                // deserialize the JSON string into a dynamic object
                var bookData = JsonConvert.DeserializeObject<dynamic>(json);
                if (bookData.totalItems == 0)
                {
                    // handle case when ISBN number is not found
                    // for example, log the error or show a message to the user
                    return false;
                }
                // access the data you need, for example the title of the book
                txtAddTitle.Text = bookData.items[0].volumeInfo.title;
                txtAddAuthor.Text = bookData.items[0].volumeInfo.authors[0];
                if (bookData.items[0].volumeInfo.imageLinks != null)
                {
                    txtAddImgUrl.Text = bookData.items[0].volumeInfo.imageLinks.thumbnail;
                }
                else
                {
                    txtAddImgUrl.Text = defaultImgUrl;
                }
                checkIsRead.Checked = false;
            }
            return true;
        }
        public bool IsValidUrl(string url)
        {
            Uri uriResult;
            if (!Uri.TryCreate(url, UriKind.Absolute, out uriResult) ||
                (uriResult.Scheme != Uri.UriSchemeHttp && uriResult.Scheme != Uri.UriSchemeHttps))
            {
                return false;
            }

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "HEAD"; // only request headers, not entire content
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                return response.StatusCode == HttpStatusCode.OK;
            }
            catch (WebException)
            {
                return false;
            }
        }

        public void AddBook(Book book)
        {
            string cmdText = @"insert into MyBooks
               (Title,Author,ISBN,CoverImageUrl,IsRead)
               values(@Title, @Author, @ISBN, @CoverImageUrl, @ISRead)";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(cmdText, con))
            {
                con.Open();
                cmd.Parameters.AddWithValue("@Title", book.Title);
                cmd.Parameters.AddWithValue("@Author", book.Author);
                cmd.Parameters.AddWithValue("@ISBN", book.ISBN);
                cmd.Parameters.AddWithValue("@CoverImageUrl", book.CoverImageUrl);
                cmd.Parameters.AddWithValue(@"IsRead", book.IsRead);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        public void DeleteBook(Book book)
        {
            string cmdText = @"DELETE FROM MyBooks WHERE id = @id";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(cmdText, con))
            {    
                con.Open();
                cmd.Parameters.AddWithValue("@id", book.Id);
                cmd.ExecuteNonQuery();
                con.Close();
            }     
        }
        public void UpdateBook(Book book)
        {
            string cmdText = @"UPDATE MyBooks SET 
                Title = @Title, 
                Author = @Author, 
                ISBN = @ISBN, 
                CoverImageUrl = @CoverImageUrl, 
                IsRead = @IsRead 
                WHERE Id = @Id";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(cmdText, con))
            {
                con.Open();
                cmd.Parameters.AddWithValue("@Title", book.Title);
                cmd.Parameters.AddWithValue("@Author", book.Author);
                cmd.Parameters.AddWithValue("@ISBN", book.ISBN);
                cmd.Parameters.AddWithValue("@CoverImageUrl", book.CoverImageUrl);
                cmd.Parameters.AddWithValue("@IsRead", book.IsRead);
                cmd.Parameters.AddWithValue("@Id", book.Id);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public Book GetBookById(int bookId)
        {
            Book book = new Book();
            string cmdText = "SELECT * FROM MyBooks WHERE Id = @bookId";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(cmdText, con))
            {
                cmd.Parameters.AddWithValue("@bookId", bookId);
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        book.Id = reader.GetInt32(0);
                        book.Title = reader.GetString(1);
                        book.Author = reader.GetString(2);
                        book.ISBN = reader.GetString(3);
                        book.CoverImageUrl = reader.GetString(4);
                        book.IsRead = reader.HasRows ? reader.GetBoolean(5) : false;
                    }
                }
                con.Close();
            }
            return book;
        }

        public List<Book> GetAllBooks()
        {
            List<Book> returnThese = new List<Book>();
            string cmdText = "SELECT * FROM MyBooks";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(cmdText, con))
            {
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Book book = new Book
                        {
                            Id = reader.GetInt32(0),
                            Title = reader.GetString(1),
                            Author = reader.GetString(2),
                            ISBN = reader.GetString(3),
                            CoverImageUrl = reader.GetString(4),
                            IsRead = reader.GetBoolean(5)
                        };
                        returnThese.Add(book);
                    }
                }
                con.Close();
            }
            return returnThese;
        }

        public List<Book> GetToReadBooks()
        {
            List<Book> returnThese = new List<Book>();
            string cmdText = "SELECT * FROM MyBooks WHERE IsRead = 0";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(cmdText, con))
            {
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Book book = new Book
                        {
                            Id = reader.GetInt32(0),
                            Title = reader.GetString(1),
                            Author = reader.GetString(2),
                            ISBN = reader.GetString(3),
                            CoverImageUrl = reader.GetString(4),
                            IsRead = reader.HasRows ? reader.GetBoolean(5) : false
                        };
                        returnThese.Add(book);
                    }
                }
                con.Close();
            }
            return returnThese;
        }

        public List<Book> GetAlreadyReadBooks()
        {
            List<Book> returnThese = new List<Book>();
            string cmdText = "SELECT * FROM MyBooks WHERE IsRead = 1";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(cmdText, con))
            {
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Book book = new Book
                        {
                            Id = reader.GetInt32(0),
                            Title = reader.GetString(1),
                            Author = reader.GetString(2),
                            ISBN = reader.GetString(3),
                            CoverImageUrl = reader.GetString(4),
                            IsRead = reader.HasRows ? reader.GetBoolean(5) : false
                        };
                        returnThese.Add(book);
                    }
                }
                con.Close();
            }
            return returnThese;
        }

        public List<Book> GetBooksBySearchPhrase(string searchPhrase)
        {
            List<Book> returnThese = new List<Book>();
            string cmdText = @"SELECT * FROM MyBooks WHERE 
                Title LIKE @SearchPhrase 
                OR Author LIKE @SearchPhrase 
                OR ISBN LIKE @SearchPhrase";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(cmdText, con))
            {
                cmd.Parameters.AddWithValue("@SearchPhrase", "%" + searchPhrase + "%");
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Book book = new Book
                        {
                            Id = reader.GetInt32(0),
                            Title = reader.GetString(1),
                            Author = reader.GetString(2),
                            ISBN = reader.GetString(3),
                            CoverImageUrl= reader.GetString(4),
                            IsRead = reader.HasRows ? reader.GetBoolean(5) : false
                        };
                        returnThese.Add(book);
                    }
                }
                con.Close();
            }
            return returnThese;
        }

        public List<Book> GetToReadBooksBySearchPhrase(string searchPhrase)
        {
            List<Book> returnThese = new List<Book>();
            string cmdText = @"SELECT * FROM MyBooks WHERE 
                (Title LIKE @SearchPhrase 
                OR Author LIKE @SearchPhrase 
                OR ISBN LIKE @SearchPhrase) 
                AND IsRead = 0";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(cmdText, con))
            {
                cmd.Parameters.AddWithValue("@SearchPhrase", "%" + searchPhrase + "%");
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Book book = new Book
                        {
                            Id = reader.GetInt32(0),
                            Title = reader.GetString(1),
                            Author = reader.GetString(2),
                            ISBN = reader.GetString(3),
                            CoverImageUrl = reader.GetString(4),
                            IsRead = reader.GetBoolean(5)
                        };
                        returnThese.Add(book);
                    }
                }
                con.Close();
            }
            return returnThese;
        }

        public List<Book> GetAlreadyReadBooksBySearchPhrase(string searchPhrase)
        {
            List<Book> returnThese = new List<Book>();
            string cmdText = @"SELECT * FROM MyBooks WHERE 
                (Title LIKE @SearchPhrase 
                OR Author LIKE @SearchPhrase 
                OR ISBN LIKE @SearchPhrase) 
                AND IsRead = 1";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(cmdText, con))
            {
                cmd.Parameters.AddWithValue("@SearchPhrase", "%" + searchPhrase + "%");
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Book book = new Book
                        {
                            Id = reader.GetInt32(0),
                            Title = reader.GetString(1),
                            Author = reader.GetString(2),
                            ISBN = reader.GetString(3),
                            CoverImageUrl = reader.GetString(4),
                            IsRead = reader.GetBoolean(5)
                        };
                        returnThese.Add(book);
                    }
                }
                con.Close();
            }
            return returnThese;
        }
    }
}