using System;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class ConexionDatos
    {
        
        private string cadenaConexion = "Server=(localdb)\\MSSQLLocalDB;Database=HospitalLinux;Integrated Security=True;TrustServerCertificate=True;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}