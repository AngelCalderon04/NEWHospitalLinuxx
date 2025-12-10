using System;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class ConexionDatos
    {
        // Cadena de conexio a la base de datos HospitalLinux
        private string cadenaConexion = "Server=.;Database=HospitalLinux;Integrated Security=True;TrustServerCertificate=True;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}

