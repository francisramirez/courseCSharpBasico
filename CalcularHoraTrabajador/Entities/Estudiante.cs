using CalcularHoraTrabajador.Contracts;
using CalcularHoraTrabajador.Datos;

namespace CalcularHoraTrabajador.Entities
{
    public class Estudiante : Persona
    {
        IPersonList personList;

        public string Matricula { get; set; }
        public string Curso { get; set; }

        public int UserMod { get; set; }

        public Estudiante()
        {
            personList = new PersonList();
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
            return personList.GetPersonas();
        }

    }
}
