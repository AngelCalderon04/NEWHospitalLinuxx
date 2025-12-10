using System;


namespace CapaNegocios
{
    public class HistorialMedico
    {
        // PROPIEDADES
        public int IDHistorialMED { get; set; }
        public int IDPaciente { get; set; }
        public int IDDoctor { get; set; }
        public DateTime FechaConsulta { get; set; }
        public string Sintomas { get; set; }
        public string Diagnostico { get; set; }
        public string Tratamiento { get; set; }
        public string Observaciones { get; set; }

        // Constructor vacio 
        public HistorialMedico()
        {
            FechaConsulta = DateTime.Now;
        }

        // construtor con Datos 
        public HistorialMedico(int idPaciente, int idDoctor, string sintomas,
                               string diagnostico, string tratamiento, string observaciones)
        {
            this.IDPaciente = idPaciente;
            this.IDDoctor = idDoctor;
            this.FechaConsulta = DateTime.Now;
            this.Sintomas = sintomas;
            this.Diagnostico = diagnostico;
            this.Tratamiento = tratamiento;
            this.Observaciones = observaciones;
        }
    }
}