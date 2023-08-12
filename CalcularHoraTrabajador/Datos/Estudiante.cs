

using CalcularHoraTrabajador.Contracts;

namespace CalcularHoraTrabajador.Datos
{
    public class Estudiante : Persona
    {
        IPersonList personList; 
        public Estudiante()
        {
            this.personList = new PersonList();
        }
        public override void CargarDatos()
        {
          
            for (int i = 0; i < 5; i++)
            {
                personList.Add(new Estudiante()
                {
                    PersonaId = i,
                    Nombre = $"Pedro {i}",
                    Apellido = $"Gonzales {i}",
                    Correo = $"pedrogon{i}@gmail.com"

                });
            }


        }

        public override void Caminar()
        {
            throw new NotImplementedException();
        }

        public List<Persona> GetEstudiantes() 
        {
            return this.personList.GetPersonas();
        }

    }
}
