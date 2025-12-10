using System;
using Personas;

namespace PersonalAdminsitrativo
{
    public class PersonalAdministrativo : Persona
    {
        // Propiedades
        public int IDAdministrativo { get; set; }
        public string Departamento { get; set; }
        public string Cargo { get; set; }
        public decimal Salario { get; set; }

        // Constructor vacio
        public PersonalAdministrativo() : base() { }

        // Constructor lleno
        public PersonalAdministrativo(string nombre, string cedula, string telefono, string email,
                                      string departamento, string cargo, decimal salario)
            : base(nombre, cedula, telefono, email, "Administrativo")
        {
            this.Departamento = departamento;
            this.Cargo = cargo;
            this.Salario = salario;
        }

        //Logica 

        public override string GenerarDiagnostico()
        {
            return $"El personal administrativo {this.Nombre} no genera diagnósticos médicos. " +
                   $"Su función es: {this.Cargo} en el departamento de {this.Departamento}.";
        }

        public override decimal CalcularHonorarios()
        {
            return this.Salario; // Sueldo fijo
        }

        public string ObtenerInformacionPuesto()
        {
            return $"Empleado: {this.Nombre}\n" +
                   $"Cargo: {this.Cargo}\n" +
                   $"Departamento: {this.Departamento}\n" +
                   $"Salario Mensual: RD${this.Salario:N2}";
        }


    }
}
