using System;

namespace Personas
{
    // Esto es la INTERFAZ (El contrato)
    public interface IOperaciones
    {
        // Obliga a quien la use a tener este método
        string ObtenerInformacion();
    }
}
