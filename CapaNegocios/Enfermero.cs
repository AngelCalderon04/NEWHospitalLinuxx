using System;
using Personas;

namespace Enfermero
{
    public class Enfermero : Persona
    {
        public int IDEnfermero { get; set; }
        public string Turno { get; set; } // Manana, Tarde, Noche
        public string Area { get; set; }  // Emergencias, UCI...

        // Constructor vacío
        public Enfermero() : base() { }

        // Constructor para crear objetos (sin ID, porque es nuevo)
        public Enfermero(string nombre, string cedula, string telefono, string email,
                         string turno, string area)
            : base(nombre, cedula, telefono, email, "Enfermero")
        {
            this.Turno = turno;
            this.Area = area;
        }

        // Implementación del metodo abstracto
        public override string GenerarDiagnostico()
        {
            return $"Reporte de enfermería generado por {this.Nombre}. Área: {this.Area}.";
        }

        //Logica para calcular honorarios de Enferemros 
        public override decimal CalcularHonorarios()
        {
            decimal tarifaBase = 500;

            if (this.Turno == "Noche")
                return tarifaBase * 1.5m; // +50%
            else if (this.Turno == "Tarde")
                return tarifaBase * 1.2m; // +20%
            else
                return tarifaBase;        // Manana
        }
    }
}