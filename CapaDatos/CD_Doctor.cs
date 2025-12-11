using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Doctor
    {
        private ConexionDatos conexion = new ConexionDatos();

        // TODO: metodo que recibe todos los datos del doctor mas usuario y clave
        public void RegistrarDoctor(string nombre, string cedula, string telefono, string email,
                                    string especialidad, string exequatur, decimal tarifa,
                                    string usuario, string clave)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    
                    // TODO: insertar en personas para obtener el id
                   
                    string sqlPersona = @"INSERT INTO Personas (Nombre, Cedula, Telefono, Email, Rol) 
                                          VALUES (@Nom, @Ced, @Tel, @Email, 'Doctor'); 
                                          SELECT SCOPE_IDENTITY();";

                    SqlCommand cmdPer = new SqlCommand(sqlPersona, conn, transaction);
                    cmdPer.Parameters.AddWithValue("@Nom", nombre);
                    cmdPer.Parameters.AddWithValue("@Ced", cedula);
                    cmdPer.Parameters.AddWithValue("@Tel", telefono);
                    cmdPer.Parameters.AddWithValue("@Email", email);

                    // TODO: guardamos el id generado
                    int idPersona = Convert.ToInt32(cmdPer.ExecuteScalar());

                   
                    // TODO: insertar en la tabla doctor
              
                    string sqlDoc = @"INSERT INTO Doctor (IDPersona, Especialidad, Exequatur, TarifaConsulta) 
                                      VALUES (@IDPer, @Esp, @Exe, @Tar);";

                    SqlCommand cmdDoc = new SqlCommand(sqlDoc, conn, transaction);
                    cmdDoc.Parameters.AddWithValue("@IDPer", idPersona);
                    cmdDoc.Parameters.AddWithValue("@Esp", especialidad);
                    cmdDoc.Parameters.AddWithValue("@Exe", exequatur);
                    cmdDoc.Parameters.AddWithValue("@Tar", tarifa);

                    cmdDoc.ExecuteNonQuery();

                    // TODO:  crear el usuario (esto faltaba)
                 
                    string sqlUsuario = @"INSERT INTO Usuarios (NombreUsuario, Clave, NivelAcceso) 
                                          VALUES (@User, @Pass, 'Doctor');";

                    SqlCommand cmdUsu = new SqlCommand(sqlUsuario, conn, transaction);
                    cmdUsu.Parameters.AddWithValue("@User", usuario);
                    cmdUsu.Parameters.AddWithValue("@Pass", clave);
                    cmdUsu.ExecuteNonQuery();

                    // TODO: guardar cambios
                    transaction.Commit();
                }
                catch (SqlException sqlEx)
                {
                    // TODO: deshacer cambios si falla
                    transaction.Rollback();

                    // TODO: verificar si es error de duplicado (cedula o usuario repetido)
                    if (sqlEx.Number == 2627 || sqlEx.Number == 2601)
                    {
                        throw new Exception("Error: La cedula o el usuario ya existen.");
                    }
                    else
                    {
                        throw new Exception("Error SQL: " + sqlEx.Message);
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("Error al guardar: " + ex.Message);
                }
            }
        }

        // TODO: metodo nuevo necesario para llenar el combo de citas
        public DataTable ListarDoctoresParaCombo()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                try
                {
                    conn.Open();
                    // AGREGAMOS 'D.TarifaConsulta' AQUI:
                    string sql = "SELECT D.IDDoctor, P.Nombre, D.TarifaConsulta FROM Doctor D INNER JOIN Personas P ON D.IDPersona = P.IDPersona";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al listar doctores: " + ex.Message);
                }
            }
            return tabla;
        }

        // TODO:  Método nuevo para ver TODA la info del doctor en el directorio
        public DataTable ListarDirectorioDoctores()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string sql = @"
            SELECT 
                P.Nombre, 
                P.Cedula, 
                P.Telefono, 
                P.Email, 
                D.Especialidad, 
                D.Exequatur, 
                D.TarifaConsulta AS Tarifa
            FROM Doctor D
            INNER JOIN Personas P ON D.IDPersona = P.IDPersona";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
            }
            return tabla;
        }
    }
}