using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Enfermero
    {
        private ConexionDatos conexion = new ConexionDatos();

        // TODO:  Agregamos 'usuario' y 'clave' para el Login
        public void RegistrarEnfermero(
            string nombre, string cedula, string telefono, string email,
            string turno, string area,
            string usuario, string clave)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();

                // TODO: INICIO TRANSACCIÓN (Todo o Nada)
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    int idPersonaGenerado = 0;


                    //TODO:  INSERTAR EN 'Personas'

                    string queryPersona = "INSERT INTO Personas (Nombre, Cedula, Telefono, Email, Rol, FechaRegistro) " +
                                          "VALUES (@Nombre, @Cedula, @Telefono, @Email, 'Enfermero', GETDATE()); " +
                                          "SELECT CAST(SCOPE_IDENTITY() AS INT);";

                    SqlCommand cmdPersona = new SqlCommand(queryPersona, conn, transaction);
                    cmdPersona.Parameters.AddWithValue("@Nombre", nombre);
                    cmdPersona.Parameters.AddWithValue("@Cedula", cedula);
                    cmdPersona.Parameters.AddWithValue("@Telefono", telefono);
                    cmdPersona.Parameters.AddWithValue("@Email", email ?? (object)DBNull.Value);

                    idPersonaGenerado = (int)cmdPersona.ExecuteScalar();


                    // TODO:  INSERTAR EN 'Enfermero'

                    string queryEnfermero = "INSERT INTO Enfermero (IDPersona, Turno, Area) " +
                                            "VALUES (@IDPersona, @Turno, @Area)";

                    SqlCommand cmdEnfermero = new SqlCommand(queryEnfermero, conn, transaction);
                    cmdEnfermero.Parameters.AddWithValue("@IDPersona", idPersonaGenerado);
                    cmdEnfermero.Parameters.AddWithValue("@Turno", turno);
                    cmdEnfermero.Parameters.AddWithValue("@Area", area);

                    cmdEnfermero.ExecuteNonQuery();


                    // TODO:  INSERTAR EN 'Usuarios' (¡NUEVO!)

                    string queryUsuario = "INSERT INTO Usuarios (NombreUsuario, Clave, NivelAcceso) " +
                                          "VALUES (@User, @Pass, 'Enfermero')";

                    SqlCommand cmdUsuario = new SqlCommand(queryUsuario, conn, transaction);
                    cmdUsuario.Parameters.AddWithValue("@User", usuario);
                    cmdUsuario.Parameters.AddWithValue("@Pass", clave);
                    cmdUsuario.ExecuteNonQuery();

                    // TODO: Confirmar cambios
                    transaction.Commit();
                }
                catch (SqlException sqlEx)
                {
                    transaction.Rollback();
                    if (sqlEx.Number == 2627 || sqlEx.Number == 2601)
                        throw new Exception("Error: Ya existe esa Cédula o ese Usuario.");
                    else
                        throw new Exception("Error SQL: " + sqlEx.Message);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("Error al guardar enfermero: " + ex.Message);
                }
            }
        }

        // Método nuevo para ver TODA la info del enfermero en el directorio
        public DataTable ListarDirectorioEnfermeros()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                // OJO: No seleccionamos Clave ni Usuario por seguridad
                string sql = @"
                    SELECT 
                        P.Nombre, 
                        P.Cedula, 
                        P.Telefono, 
                        E.Turno, 
                        E.Area
                    FROM Enfermero E
                    INNER JOIN Personas P ON E.IDPersona = P.IDPersona";

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
            }
            return tabla;
        }
    }
}