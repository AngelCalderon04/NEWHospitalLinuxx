using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class CD_HistorialMedico
    {
        private ConexionDatos conexion = new ConexionDatos();

        // Método solo para LEER (Reporte Completo)
        public DataTable ListarHistorialDetallado()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                // SQL: Unimos todo para tener la ficha completa
                string sql = @"
                    SELECT 
                        H.IDHistorialMED,
                        
                        -- DATOS PERSONALES
                        PerPac.Nombre AS Paciente,
                        PerPac.Cedula AS Cedula,
                        
                        -- DATOS MEDICOS DEL PACIENTE (NUEVO)
                        P.GrupoSanguineo AS Sangre,
                        P.NumeroSeguro AS Seguro,
                        P.Peso AS Peso,
                        P.Altura AS Altura,

                        -- DATOS DE LA CONSULTA
                        H.FechaConsulta AS Fecha,
                        PerDoc.Nombre AS Doctor,
                        H.Diagnostico,
                        H.Tratamiento,
                        H.Observaciones,
                        
                        -- IDs OCULTOS
                        H.IDPaciente
                    FROM HistorialMedico H
                    INNER JOIN Paciente P ON H.IDPaciente = P.IDPaciente
                    INNER JOIN Personas PerPac ON P.IDPersona = PerPac.IDPersona
                    INNER JOIN Doctor D ON H.IDDoctor = D.IDDoctor
                    INNER JOIN Personas PerDoc ON D.IDPersona = PerDoc.IDPersona
                    ORDER BY H.FechaConsulta DESC";

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
            }
            return tabla;
        }

        // Mantengo el método de registrar por si lo usas en otro lado, 
        // pero este form solo usará el de Listar.
        public void RegistrarHistorial(int idPaciente, int idDoctor, string sintomas, string diagnostico, string tratamiento, string observaciones)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "INSERT INTO HistorialMedico (IDPaciente, IDDoctor, FechaConsulta, Sintomas, Diagnostico, Tratamiento, Observaciones) VALUES (@IdPac, @IdDoc, GETDATE(), @Sintomas, @Diag, @Trata, @Obs)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdPac", idPaciente);
                cmd.Parameters.AddWithValue("@IdDoc", idDoctor);
                cmd.Parameters.AddWithValue("@Sintomas", sintomas);
                cmd.Parameters.AddWithValue("@Diag", diagnostico);
                cmd.Parameters.AddWithValue("@Trata", tratamiento);
                cmd.Parameters.AddWithValue("@Obs", observaciones ?? (object)DBNull.Value);
                cmd.ExecuteNonQuery();
            }
        }
    }
}