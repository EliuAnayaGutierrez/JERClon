namespace Comun
{
    public static class UserCache
    {
        public static int IdUsuario {  get; set; }
        public static string Usuario { get; set; }
        public static string Correo { get; set; }
        public static string Contraseña { get; set; }
        public static int IdMinistro { get; set; }
        public static string ApPaterno { get; set; }
        public static string ApMaterno { get; set; }
        public static string Nombres { get; set; }
        public static int IdRol {  get; set; }
        public static string Rol { get; set; }
        public static int Estatus { get; set; }
    }

    public class UserCacheConsult
    {
        public int IdUsuario { get; set; }
        public string Usuario { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }
        public int IdMinistro { get; set; }
        public string ApPaterno { get; set; }
        public string ApMaterno { get; set; }
        public string Nombres { get; set; }
        public int IdRol { get; set; }
        public string Rol { get; set; }
        public int Estatus { get; set; }
    }

}
