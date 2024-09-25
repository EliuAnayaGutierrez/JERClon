using MySql.Data.MySqlClient;

namespace Controlador
{
    public abstract class ConnectionToMySQL
    {
        private readonly string connectionString;

        public ConnectionToMySQL() 
        {
            //connectionString = "Server=161.132.40.158; Database=bd_jer; User=root; port=3306; password=c2Vd4KEY1H541xqlz5nb";
            connectionString = "Server=localhost; Database=bd_jer; User=root; port=3306; password=12345";
        }

        protected MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
