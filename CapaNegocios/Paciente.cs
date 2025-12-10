using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Personas;

namespace Pacientes
{
    //Heredade persona
    public class Paciente : Persona
    {
        // Propiedades
        public int IDPaciente { get; set; }
        public DateTime? FechaNacimiento { get; set; }  //agreado
        public string GrupoSanguineo { get; set; }
        public string Alergias { get; set; }
        public string NumeroSeguro { get; set; }
        public string ContactoEmergencia { get; set; }
        public decimal? Peso { get; set; }  // Agregado
        public decimal? Altura { get; set; }  // agregado 


        // Constructor vacío para consultar a la base de Datos 
        public Paciente() : base()
        {
        }

        // Constructor con parametros
        public Paciente(string Nombre, string Cedula, string Telefono, string Email,
                       DateTime? FechaNacimiento, string GrupoSanguineo, string Alergias,
                       string NumeroSeguro, string ContactoEmergencia, decimal? Peso, decimal? Altura)
            : base(Nombre, Cedula, Telefono, Email, "Paciente")
        {
            this.FechaNacimiento = FechaNacimiento;
            this.GrupoSanguineo = GrupoSanguineo;
            this.Alergias = Alergias;
            this.NumeroSeguro = NumeroSeguro;
            this.ContactoEmergencia = ContactoEmergencia;
            this.Peso = Peso;
            this.Altura = Altura;
        }



        public override string GenerarDiagnostico()
        {
            return $"El paciente {this.Nombre} no puede generar diagnósticos. Solo los recibe del doctor.";
        }

        public override decimal CalcularHonorarios()
        {
            return 0; // Los pacientes no cobran
        }

        public string ObtenerInformacionMedica()
        {
            return $"Paciente: {this.Nombre}\n" +
                   $"Grupo Sanguíneo: {this.GrupoSanguineo}\n" +
                   $"Alergias: {(string.IsNullOrEmpty(this.Alergias) ? "Ninguna" : this.Alergias)}\n" +
                   $"Contacto de Emergencia: {this.ContactoEmergencia}";
        }




    }
}