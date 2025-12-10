using System;


namespace Personas
{
    // Clase padre BASE 
    public abstract class Persona
    {
        // PROPIEDADES (Solo datos)
        public int IDPersona { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Rol { get; set; }
        public DateTime FechaRegistro { get; set; }


        // Constructor vacio necesario para cuando llenamos datos desde la Base de datos
        public Persona()
        {
        }

        // Constructor para crear nuevos registros desde el codigo
        public Persona(string Nombre, string Cedula, string Telefono, string Email, string Rol)
        {
            this.Nombre = Nombre;
            this.Cedula = Cedula;
            this.Telefono = Telefono;
            this.Email = Email;
            this.Rol = Rol;
        }

        //  MeTODOS DE NEGOCIO 

        // Metodo abstracto ESTE Obliga a los hijos a decir como hacen sus diagnosticos
        public abstract string GenerarDiagnostico();

        // Metodo virtual este Define un comportamiento base (cobrar 0) que los hijos pueden cambiar
        public virtual decimal CalcularHonorarios()
        {
            return 0;
        }


    }
}