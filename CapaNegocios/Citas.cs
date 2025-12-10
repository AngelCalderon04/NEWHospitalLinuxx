using System;

namespace Citas
{
    public class Citas
    {
        public int IDCita { get; set; }
        public int IDPaciente { get; set; }
        public int IDDoctor { get; set; }
        public DateTime FechaCita { get; set; }
        public TimeSpan HoraCita { get; set; }
        public string MotivoCita { get; set; }
        public string Estado { get; set; } // Agregado para coincidir con la Base de datos 

        // Constructor vacío
        public Citas() { }

        // Constructor lleno
        public Citas(int idPaciente, int idDoctor, DateTime fechaCita, TimeSpan horaCita, string motivoCita)
        {
            this.IDPaciente = idPaciente;
            this.IDDoctor = idDoctor;
            this.FechaCita = fechaCita;
            this.HoraCita = horaCita;
            this.MotivoCita = motivoCita;
            this.Estado = "Pendiente"; // Valor por defecto
        }


    }
}