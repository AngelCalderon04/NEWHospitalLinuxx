using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Usuario
    {
        private ConexionDatos conexion = new ConexionDatos();

        // TODO:Metodo para validar si el usuario existe
        public bool Login(string usuario, string clave)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string sql = "SELECT COUNT(*) FROM Usuarios WHERE NombreUsuario = @user AND Clave = @pass";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@user", usuario);
                cmd.Parameters.AddWithValue("@pass", clave);

                int resultado = (int)cmd.ExecuteScalar();

                // TODO: Si resultado es mayor a 0, es que encontro al usuario
                return resultado > 0;
            }
        }
    }
}