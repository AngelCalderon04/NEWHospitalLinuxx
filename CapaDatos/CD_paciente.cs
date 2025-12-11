using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Paciente
    {
        private ConexionDatos conexion = new ConexionDatos();


        public void RegistrarPaciente(
            string nombre, string cedula, string telefono, string email,
            DateTime? fechaNac, string sangre, string alergias,
            string seguro, string emergencia, decimal? peso, decimal? altura)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();

                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    int idPersonaGenerado = 0;

                    // TODO:INSERTAR EN PERSONA
                    string queryPersona = "INSERT INTO Personas (Nombre, Cedula, Telefono, Email, Rol) " +
                                          "VALUES (@Nombre, @Cedula, @Telefono, @Email, 'Paciente'); " +
                                          "SELECT CAST(SCOPE_IDENTITY() AS INT);";

                    SqlCommand cmdPersona = new SqlCommand(queryPersona, conn, transaction);
                    cmdPersona.Parameters.AddWithValue("@Nombre", nombre);
                    cmdPersona.Parameters.AddWithValue("@Cedula", cedula);
                    cmdPersona.Parameters.AddWithValue("@Telefono", telefono);
                    cmdPersona.Parameters.AddWithValue("@Email", email ?? (object)DBNull.Value);

                    idPersonaGenerado = (int)cmdPersona.ExecuteScalar();

                    //TODO: INSERTAR TABLA PACIENTE 
                    string queryPaciente = "INSERT INTO Paciente (IDPersona, FechaNacimiento, GrupoSanguineo, Alergias, NumeroSeguro, ContactoEmergencia, Peso, Altura) " +
                                           "VALUES (@IDPersona, @FechaNacimiento, @GrupoSanguineo, @Alergias, @NumeroSeguro, @ContactoEmergencia, @Peso, @Altura)";

                    SqlCommand cmdPaciente = new SqlCommand(queryPaciente, conn, transaction);
                    cmdPaciente.Parameters.AddWithValue("@IDPersona", idPersonaGenerado);
                    cmdPaciente.Parameters.AddWithValue("@FechaNacimiento", fechaNac ?? (object)DBNull.Value);
                    cmdPaciente.Parameters.AddWithValue("@GrupoSanguineo", sangre ?? (object)DBNull.Value);
                    cmdPaciente.Parameters.AddWithValue("@Alergias", alergias ?? (object)DBNull.Value);
                    cmdPaciente.Parameters.AddWithValue("@NumeroSeguro", seguro ?? (object)DBNull.Value);
                    cmdPaciente.Parameters.AddWithValue("@ContactoEmergencia", emergencia ?? (object)DBNull.Value);
                    cmdPaciente.Parameters.AddWithValue("@Peso", peso ?? (object)DBNull.Value);
                    cmdPaciente.Parameters.AddWithValue("@Altura", altura ?? (object)DBNull.Value);

                    cmdPaciente.ExecuteNonQuery();
                    //uardar cambios 
                    transaction.Commit();
                }
                catch (SqlException sqlEx)
                {
                    transaction.Rollback(); // Deshacemos todo si falla

                    // TODO Error 2627 es "Clave duplicada" (Cédula repetida)
                    if (sqlEx.Number == 2627 || sqlEx.Number == 2601)
                    {
                        throw new Exception("Error: Ya existe un paciente registrado con esa Cédula.");
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


        public DataTable Listar()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT IDPaciente, Nombre FROM Personas INNER JOIN Paciente ON Personas.IDPersona = Paciente.IDPersona";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al listar pacientes: " + ex.Message);
                }
            }
            return tabla;
        }
    }
}