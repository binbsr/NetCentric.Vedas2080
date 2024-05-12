using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace Identity_Demo.Controllers
{
    public class BooksController : Controller
    {
        private readonly string _connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=aspnet-Identity_Demo-dae36e9b-4074-4d70-bb1a-49b93a107df8;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult PopulateData()
        {
            Initialize();
            return Ok();
        }

        public void Initialize()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                // Create table if not exists
                var createTableSql = @"IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Books')
                                CREATE TABLE Books (
                                    Id INT PRIMARY KEY IDENTITY,
                                    Name NVARCHAR(100),
                                    Author NVARCHAR(100),
                                    Price DECIMAL(10, 2)
                                )";
                using (var command = new SqlCommand(createTableSql, connection))
                {
                    command.ExecuteNonQuery();
                }

                // Insert sample data
                var insertDataSql = @"INSERT INTO Books (Name,Author, Price) VALUES
                                ('To kill a mockingbird','harper lee', 999.99),
                                ('And Then There Were None','Agatha Christie', 19.99),
                                ('Palpasa Café','Narayan Wagle', 49.99)";
                using (var command = new SqlCommand(insertDataSql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        [HttpPost]
        public IActionResult SearchProducts(string keyword)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var sql = $"SELECT * FROM Books WHERE Name LIKE @Keyword"; //'; DROP TABLE Products --

                // var sql = $"SELECT * FROM Products WHERE ID = {keyword}";  //1 or 1=1;
                var command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                var reader = command.ExecuteReader();

                var products = new List<Books>();
                while (reader.Read())
                {
                    var product = new Books
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Author = reader.GetString(2),
                        Price = reader.GetDecimal(3)
                    };
                    products.Add(product);
                }

                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public IActionResult GetBooks()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var sql = $"SELECT * FROM Books"; //'; DROP TABLE Products --

                // var sql = $"SELECT * FROM Products WHERE ID = {keyword}";  //1 or 1=1;
                var command = new SqlCommand(sql, connection);
                var reader = command.ExecuteReader();

                var products = new List<Books>();
                while (reader.Read())
                {
                    var product = new Books
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Author = reader.GetString(2),
                        Price = reader.GetDecimal(3)
                    };
                    products.Add(product);
                }

                return Ok(products);
            }
        }

        [HttpGet]
        public IActionResult RedirectHelper(string url)
        {
            if(!Url.IsLocalUrl(url)) return BadRequest();
            
            return Redirect(url);
        }
    }

    public class Books
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
    }
}
