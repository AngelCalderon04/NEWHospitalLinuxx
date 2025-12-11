using System;
using Personas;

namespace Doctor
{
    // TODO: Hereda de Persona
    public class Doctor : Persona
    {
        //TODO: Propiedades exclusivas del Doctor
        public int IDDoctor { get; set; }
        public string Especialidad { get; set; }
        public string Exequatur { get; set; }
        public decimal TarifaConsulta { get; set; }

        // TODO:Constructor Vacio
        public Doctor() : base() { }

        // TODO: Constructor lleno
        public Doctor(string nombre, string cedula, string telefono, string email,
                      string especialidad, string exequatur, decimal tarifa)
            : base(nombre, cedula, telefono, email, "Doctor")
        {
            this.Especialidad = especialidad;
            this.Exequatur = exequatur;
            this.TarifaConsulta = tarifa;
        }


        //TODO:Implementacion de metodo abstrato 
        public override string GenerarDiagnostico()
        {
            //TODO:  El doctor SI tiene permiso para diagnosticar
            return $"El Dr. {this.Nombre} está redactando un diagnóstico clínico.";
        }


        public override decimal CalcularHonorarios()
        {
            //TODO: El Paciente devolvía 0. El Doctor devuelve su tarifa.
            return this.TarifaConsulta;
        }
    }
}


