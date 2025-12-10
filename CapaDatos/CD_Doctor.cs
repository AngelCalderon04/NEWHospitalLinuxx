using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Doctor
    {
        private ConexionDatos conexion = new ConexionDatos();

        // Método para guardar TODO de un solo golpe (Transacción)
        public void RegistrarDoctor(
            string nombre, string cedula, string telefono, string email, // Datos Persona
            string especialidad, string exequatur, decimal tarifa,       // Datos Doctor (Tus parámetros)
            string usuario, string clave)                                // Datos Usuario
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    int idPersonaGenerado = 0;

                    // ---------------------------------------------------
                    // PASO 1: INSERTAR EN 'Personas'
                    // ---------------------------------------------------
                    // Nota: Si tu tabla Personas NO permite vacíos en Cédula,
                    // asegúrate de enviar datos reales o permitir NULL en la BD.
                    string queryPersona = "INSERT INTO Personas (Nombre, Cedula, Telefono, Email, Rol, FechaRegistro) " +
                                          "VALUES (@Nombre, @Cedula, @Telefono, @Email, 'Doctor', GETDATE()); " +
                                          "SELECT CAST(SCOPE_IDENTITY() AS INT);";

                    SqlCommand cmdPersona = new SqlCommand(queryPersona, conn, transaction);
                    cmdPersona.Parameters.AddWithValue("@Nombre", nombre);
                    cmdPersona.Parameters.AddWithValue("@Cedula", cedula);
                    cmdPersona.Parameters.AddWithValue("@Telefono", telefono);
                    cmdPersona.Parameters.AddWithValue("@Email", email ?? (object)DBNull.Value);

                    idPersonaGenerado = (int)cmdPersona.ExecuteScalar(); // Recuperamos el ID creado

                    // ---------------------------------------------------
                    // PASO 2: INSERTAR EN 'Doctor' (Con tus parámetros exactos)
                    // ---------------------------------------------------
                    string queryDoctor = @"INSERT INTO Doctor 
                                          (IDPersona, Especialidad, Exequatur, TarifaConsulta) 
                                          VALUES 
                                          (@IDPersona, @Especialidad, @Exequatur, @Tarifa)";

                    SqlCommand cmdDoctor = new SqlCommand(queryDoctor, conn, transaction);
                    cmdDoctor.Parameters.AddWithValue("@IDPersona", idPersonaGenerado); // FK_Doctor_Persona
                    cmdDoctor.Parameters.AddWithValue("@Especialidad", especialidad);   // NVARCHAR(100)
                    cmdDoctor.Parameters.AddWithValue("@Exequatur", exequatur);         // NVARCHAR(100)
                    cmdDoctor.Parameters.AddWithValue("@Tarifa", tarifa);               // DECIMAL(10,2)

                    cmdDoctor.ExecuteNonQuery();

                    // ---------------------------------------------------
                    // PASO 3: INSERTAR EN 'Usuarios'
                    // ---------------------------------------------------
                    string queryUsuario = "INSERT INTO Usuarios (NombreUsuario, Clave, NivelAcceso) " +
                                          "VALUES (@User, @Pass, 'Doctor')";

                    SqlCommand cmdUsuario = new SqlCommand(queryUsuario, conn, transaction);
                    cmdUsuario.Parameters.AddWithValue("@User", usuario);
                    cmdUsuario.Parameters.AddWithValue("@Pass", clave);
                    cmdUsuario.ExecuteNonQuery();

                    // Confirmar todo
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    // Si falla algo, deshacemos todo
                    transaction.Rollback();
                    throw new Exception("Error al registrar doctor: " + ex.Message);
                }
            }
        }
    }
}
