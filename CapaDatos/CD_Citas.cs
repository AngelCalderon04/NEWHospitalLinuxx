using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Citas
    {
        private ConexionDatos conexion = new ConexionDatos();

        // 1. MÉTODO NUEVO (Faltaba este): Para llenar el DataGridView
        public DataTable Listar()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                try
                {
                    conn.Open();
                    // Seleccionamos todo de la tabla Citas
                    string query = "SELECT * FROM Citas";

                    // OJO: Si quieres que aparezcan los Nombres en vez de los ID, 
                    // deberías usar un INNER JOIN en el futuro. Por ahora usamos SELECT *

                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al listar las citas: " + ex.Message);
                }
            }
            return tabla;
        }

        // 2. Agendar Cita
        public void AgendarCita(int idPaciente, int idDoctor, DateTime fecha, TimeSpan hora, string motivo)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                try
                {
                    // NOTA: He descomentado MotivoCita por si tu base de datos tiene esa columna.
                    // Si NO tienes la columna 'MotivoCita' en SQL, borra la línea de @MotivoCita.

                    string query = "INSERT INTO Citas (IDPaciente, IDDoctor, FechaCita, HoraCita, Estado, MotivoCita) " +
                                   "VALUES (@IDPaciente, @IDDoctor, @FechaCita, @HoraCita, 'Pendiente', @MotivoCita)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@IDPaciente", idPaciente);
                    cmd.Parameters.AddWithValue("@IDDoctor", idDoctor);
                    cmd.Parameters.AddWithValue("@FechaCita", fecha);
                    cmd.Parameters.AddWithValue("@HoraCita", hora);

                    // Manejo de nulos para el motivo
                    if (string.IsNullOrEmpty(motivo))
                        cmd.Parameters.AddWithValue("@MotivoCita", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@MotivoCita", motivo);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al agendar la cita: " + ex.Message);
                }
            }
        }

        // 3. Editar Cita
        public void EditarCita(int idCita, int idPaciente, int idDoctor, DateTime fecha, TimeSpan hora)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                try
                {
                    conn.Open();
                    string query = @"UPDATE Citas 
                                     SET IDPaciente = @idPac, 
                                         IDDoctor = @idDoc, 
                                         FechaCita = @fecha, 
                                         HoraCita = @hora 
                                     WHERE IDCita = @id";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idPac", idPaciente);
                    cmd.Parameters.AddWithValue("@idDoc", idDoctor);
                    cmd.Parameters.AddWithValue("@fecha", fecha);
                    cmd.Parameters.AddWithValue("@hora", hora);
                    cmd.Parameters.AddWithValue("@id", idCita);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al editar la cita: " + ex.Message);
                }
            }
        }
    }
}