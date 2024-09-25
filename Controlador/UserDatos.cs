using MySql.Data.MySqlClient;
using System.Data;
using Comun;

namespace Controlador
{
    public class UserDatos: ConnectionToMySQL
    {
        public bool Login(string user, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand()) 
                { 
                    command.Connection = connection;
                    command.CommandText = "VerificarUsuario";
                    command.Parameters.AddWithValue("p_user", user);
                    command.Parameters.AddWithValue("p_pass", pass);
                    command.CommandType = CommandType.StoredProcedure;
                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        while (reader.Read()) 
                        {
                            UserCache.IdUsuario = reader.GetInt32(0);
                            UserCache.Usuario=reader.GetString(1);
                            UserCache.Correo = reader.GetString(2);
                            UserCache.Contraseña = reader.GetString(3);
                            UserCache.Rol=reader.GetString(4);
                            UserCache.Nombres = reader.GetString(5);
                            UserCache.ApPaterno = reader.GetString(6);
                            UserCache.ApMaterno = reader.GetString(7);
                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
        }


    }
}
