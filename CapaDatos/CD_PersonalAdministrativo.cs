using System;
using System.Data;
using Microsoft.Data.SqlClient; // Usamos el conector moderno para .NET 8

namespace CapaDatos
{
    public class CD_PersonalAdministrativo
    {
        private ConexionDatos conexion = new ConexionDatos();

        public void RegistrarPersonal(string nombre, string cedula, string telefono, string email, string departamento, string cargo, string usuario, string clave)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();

                // INICIAMOS UNA TRANSACCIÓN (Para que se guarden las 3 cosas o ninguna)
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // -----------------------------------------------------------------
                    // PASO 1: INSERTAR EN LA TABLA "PERSONAS" (El Humano)
                    // -----------------------------------------------------------------
                    string sqlPersona = @"INSERT INTO Personas (Nombre, Cedula, Telefono, Email, Rol) 
                                          VALUES (@Nom, @Ced, @Tel, @Email, 'Administrativo'); 
                                          SELECT SCOPE_IDENTITY();"; // Esto nos devuelve el ID nuevo

                    SqlCommand cmdPersona = new SqlCommand(sqlPersona, conn, transaction);
                    cmdPersona.Parameters.AddWithValue("@Nom", nombre);
                    cmdPersona.Parameters.AddWithValue("@Ced", cedula);
                    cmdPersona.Parameters.AddWithValue("@Tel", telefono);
                    cmdPersona.Parameters.AddWithValue("@Email", email);

                    // Ejecutamos y guardamos el ID del nuevo humano
                    int idPersonaGenerado = Convert.ToInt32(cmdPersona.ExecuteScalar());


                    // -----------------------------------------------------------------
                    // PASO 2: INSERTAR EN "PERSONAL ADMINISTRATIVO" (El Empleado)
                    // -----------------------------------------------------------------
                    // Nota: Como tu formulario no pide Salario, pondremos 0 por defecto para que no falle.
                    string sqlAdmin = @"INSERT INTO PersonalAdministrativo (IDPersona, Cargo, Departamento, Salario) 
                                        VALUES (@IDPer, @Car, @Dep, 0);";

                    SqlCommand cmdAdmin = new SqlCommand(sqlAdmin, conn, transaction);
                    cmdAdmin.Parameters.AddWithValue("@IDPer", idPersonaGenerado); // Usamos el ID del paso 1
                    cmdAdmin.Parameters.AddWithValue("@Car", cargo);
                    cmdAdmin.Parameters.AddWithValue("@Dep", departamento);
                    cmdAdmin.ExecuteNonQuery();


                    // -----------------------------------------------------------------
                    // PASO 3: INSERTAR EN "USUARIOS" (El Login)
                    // -----------------------------------------------------------------
                    string sqlUsuario = @"INSERT INTO Usuarios (NombreUsuario, Clave, NivelAcceso) 
                                          VALUES (@Usu, @Cla, 'Admin');";

                    SqlCommand cmdUsuario = new SqlCommand(sqlUsuario, conn, transaction);
                    cmdUsuario.Parameters.AddWithValue("@Usu", usuario);
                    cmdUsuario.Parameters.AddWithValue("@Cla", clave);
                    cmdUsuario.ExecuteNonQuery();

                    // SI TODO SALIÓ BIEN, GUARDAMOS LOS CAMBIOS REALMENTE
                    transaction.Commit();
                }
                catch (Exception)
                {
                    // SI ALGO FALLA (ej. Cédula repetida), DESHACEMOS TODO
                    transaction.Rollback();
                    throw; // Le avisamos al formulario que hubo error
                }
            }
        }

        // (Aquí puedes agregar el método ValidarLogin más adelante)
    }
}