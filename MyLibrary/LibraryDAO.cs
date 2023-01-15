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

    }
}
