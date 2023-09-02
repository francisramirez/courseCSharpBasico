
using CalcularHoraTrabajador.Datos;
using CalcularHoraTrabajador.Entities;

namespace CalcularHoraTrabajador.Core
{
    public static class PersonaDb
    {
        public static Persona GetPersona() 
        {
            return new Estudiante();
        }
    }
}
