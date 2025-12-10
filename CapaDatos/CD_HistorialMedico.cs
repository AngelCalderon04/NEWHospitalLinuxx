using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class CD_HistorialMedico
    {
        private ConexionDatos conexion = new ConexionDatos();

        //METODO PARA INSERTAR NUEVA CONSULTA
        public void RegistrarConsulta(int idPaciente, int idDoctor, string sintomas,
                                      string diagnostico, string tratamiento, string observaciones)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                try
                {
                    string sql = "INSERT INTO HistorialMedico (IDPaciente, IDDoctor, FechaConsulta, Sintomas, Diagnostico, Tratamiento, Observaciones) " +
                                 "VALUES (@IDPaciente, @IDDoctor, GETDATE(), @Sintomas, @Diagnostico, @Tratamiento, @Observaciones)";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@IDPaciente", idPaciente);
                    cmd.Parameters.AddWithValue("@IDDoctor", idDoctor);

                    // Manejo de nulos si envías null, se guarda DBNull
                    cmd.Parameters.AddWithValue("@Sintomas", sintomas ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Diagnostico", diagnostico ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Tratamiento", tratamiento ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Observaciones", observaciones ?? (object)DBNull.Value);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al guardar historial: " + ex.Message);
                }
            }
        }

        // METODO PARA ACTUALIZAR EDITAR UNA CONSULTA EXISTENTE
        public void ActualizarConsulta(int idHistorial, string sintomas,
                                       string diagnostico, string tratamiento, string observaciones)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                try
                {
                    string sql = "UPDATE HistorialMedico SET " +
                                 "Sintomas = @Sintomas, " +
                                 "Diagnostico = @Diagnostico, " +
                                 "Tratamiento = @Tratamiento, " +
                                 "Observaciones = @Observaciones " +
                                 "WHERE IDHistorialMED = @IDHistorial";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@IDHistorial", idHistorial);
                    cmd.Parameters.AddWithValue("@Sintomas", sintomas ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Diagnostico", diagnostico ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Tratamiento", tratamiento ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@Observaciones", observaciones ?? (object)DBNull.Value);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al actualizar historial: " + ex.Message);
                }
            }
        }

        // METODO PARA LEER (LLENAR DATAGRIDVIEW)

        public DataTable ObtenerHistorialPorPaciente(int idPaciente)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                try
                {
                    string sql = @"SELECT 
                                     H.IDHistorialMED, -- Importante traer el ID por si queremos editar luego
                                     H.FechaConsulta AS 'Fecha', 
                                     H.Sintomas, 
                                     H.Diagnostico, 
                                     H.Tratamiento, 
                                     H.Observaciones,
                                     Per.Nombre AS 'Doctor'
                                   FROM HistorialMedico H
                                   INNER JOIN Doctor D ON H.IDDoctor = D.IDDoctor
                                   INNER JOIN Personas Per ON D.IDPersona = Per.IDpersona
                                   WHERE H.IDPaciente = @IDPaciente
                                   ORDER BY H.FechaConsulta DESC";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@IDPaciente", idPaciente);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                catch (Exception ex)
                {

                    throw new Exception("Error al leer historial: " + ex.Message);
                }
            }
            return dt;
        }
    }
}