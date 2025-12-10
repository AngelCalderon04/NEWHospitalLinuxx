using System;
using System.Data;
using Microsoft.Data.SqlClient; 
namespace CapaDatos
{
    public class CD_PersonalAdministrativo
    {
        private ConexionDatos conexion = new ConexionDatos();

        // TODO: metodo para guardar administrativo completo
        public void RegistrarPersonal(string nombre, string cedula, string telefono, string email, string departamento, string cargo, decimal salario, string usuario, string clave)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();

                // TODO: iniciamos una transaccion para guardar todo junto o nada
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    
                    // TODO:  insertar en tabla personas el humano
                   
                    string sqlPersona = @"INSERT INTO Personas (Nombre, Cedula, Telefono, Email, Rol) 
                                          VALUES (@Nom, @Ced, @Tel, @Email, 'Administrativo'); 
                                          SELECT SCOPE_IDENTITY();";

                    SqlCommand cmdPersona = new SqlCommand(sqlPersona, conn, transaction);
                    cmdPersona.Parameters.AddWithValue("@Nom", nombre);
                    cmdPersona.Parameters.AddWithValue("@Ced", cedula);
                    cmdPersona.Parameters.AddWithValue("@Tel", telefono);
                    cmdPersona.Parameters.AddWithValue("@Email", email);

                    // TODO: guardamos el id que se creo
                    int idPersonaGenerado = Convert.ToInt32(cmdPersona.ExecuteScalar());


             
                    // TODO:  insertar datos del empleado con su salario
                 
                    string sqlAdmin = @"INSERT INTO PersonalAdministrativo (IDPersona, Cargo, Departamento, Salario) 
                                        VALUES (@IDPer, @Car, @Dep, @Sal);";

                    SqlCommand cmdAdmin = new SqlCommand(sqlAdmin, conn, transaction);
                    cmdAdmin.Parameters.AddWithValue("@IDPer", idPersonaGenerado);
                    cmdAdmin.Parameters.AddWithValue("@Car", cargo);
                    cmdAdmin.Parameters.AddWithValue("@Dep", departamento);
                    cmdAdmin.Parameters.AddWithValue("@Sal", salario); // TODO: aqui enviamos el dinero real


                 
                    // TODO:  crear el usuario y clave para el login
             
                    string sqlUsuario = @"INSERT INTO Usuarios (NombreUsuario, Clave, NivelAcceso) 
                                          VALUES (@Usu, @Cla, 'Admin');";

                    SqlCommand cmdUsuario = new SqlCommand(sqlUsuario, conn, transaction);
                    cmdUsuario.Parameters.AddWithValue("@Usu", usuario);
                    cmdUsuario.Parameters.AddWithValue("@Cla", clave);
                    cmdUsuario.ExecuteNonQuery();

                    // TODO: si todo salio bien guardamos los cambios
                    transaction.Commit();
                }
                catch (Exception)
                {
                    // TODO: si algo fallo deshacemos todo
                    transaction.Rollback();
                    throw;
                }
            }
        }

        
        public bool Login(string usuario, string clave)
        {
           
            return false;
        }
    }
}