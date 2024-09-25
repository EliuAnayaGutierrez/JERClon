using Controlador;

public class UserModel
{ 
    UserDatos userDatos = new UserDatos();
    public bool LoginUser(string username,string password)
    {
        return userDatos.Login(username,password);
    }
}
