using CalcularHoraTrabajador.Datos;

namespace CalcularHoraTrabajador.Contracts
{
    public interface IPersonList
    {
        void Add(Persona persona);
        void AddRange(List<Persona> personas);
        void Remove(Persona persona);

        bool Exists(string nombre);

        List<Persona> GetPersonas();
    }
    public class PersonList : IPersonList

    {
        private List<Persona> personas;
        public PersonList()
        {
            this.personas = new List<Persona>();
        }
        public void Add(Persona persona)
        {
            this.personas.Add(persona);
        }

        public void AddRange(List<Persona> personas)
        {
            this.personas.AddRange(personas);
        }

        public bool Exists(string nombre)
        {
            return this.personas.Any(cd => cd.Nombre == nombre);
        }

        public List<Persona> GetPersonas()
        {
            return this.personas;
        }

        public void Remove(Persona persona)
        {
            this.personas.Remove(persona);
        }
    }
}
