using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class LibraryDAO
    {
        string connectionString = "Server=tcp:wsb-projects.database.windows.net,1433;Initial Catalog=MyLibrary;Persist Security Info=False;User ID=admin1;Password=zaq1@WSX;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public void AddBook(Book book)
        {

            string cmdText = @"insert into Books
                   (Title,Author,ISBN)
                   values(@Title, @Author, @ISBN)";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(cmdText, con))
            {
                con.Open();
                cmd.Parameters.AddWithValue("@Title", book.Title);
                cmd.Parameters.AddWithValue("@Author", book.Author);
                cmd.Parameters.AddWithValue("@ISBN", book.ISBN);

                cmd.ExecuteNonQuery();

                con.Close();
            }
        }
        public void DeleteBook(Book book)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("DELETE FROM books WHERE id = @id", con))
            {    
                con.Open();

                cmd.Parameters.AddWithValue("@id", book.Id);
                cmd.ExecuteNonQuery();

                con.Close();
            }    
            
        }

        public List<Book> GetAllBooks()
        {
            List<Book> returnThese = new List<Book>();
            
            string cmdText = "SELECT * FROM Books";

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
                            ISBN = reader.GetString(3)
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
