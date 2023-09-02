using CalcularHoraTrabajador.Core;
using CalcularHoraTrabajador.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularHoraTrabajador.Datos
{
    public class EstudianteDb
    {
        private List<Estudiante> estudiantes = new List<Estudiante>();
        public Estudiante GetEstudiante() 
        {
            var persona = PersonaDb.GetPersona();   

            Estudiante estudiante = new Estudiante()
            {
                Apellido = persona.Apellido, 
                Color = persona.Color
            };

            return estudiante;
        }

        /// <summary>
        /// Buscar estudiantes por matricula 
        /// </summary>
        /// <param name="matricula">Matricula del estudiante</param>
        /// <returns></returns>
        public Estudiante GetEstudiante(string matricula) 
        {
            Estudiante estudiante = new Estudiante();

            estudiante = this.estudiantes.SingleOrDefault(cd => cd.Matricula == matricula);

            return estudiante;
        }

        public Estudiante GetEstudiante(int estudianteId) 
        {
            return new Estudiante();
        }

        /// <summary>
        /// Buscar estudiantes por matricula y curso
        /// </summary>
        /// <param name="matricula">Matricula del estudiante</param>
        /// <param name="curso">Curso donde esta inscripto el estudiante.</param>
        /// <returns></returns>
        public List<Estudiante> GetEstudiantes(string matricula, string curso)
        {
            List<Estudiante> estudiantes = new List<Estudiante>();

            return estudiantes;
        }
        public List<Estudiante> GetEstudiantes(string curso, out int result) 
        {
            List<Estudiante> estudiantes = new List<Estudiante>();

            result = 0;

            return estudiantes;
        }

        public bool GuardarEstudiante(Estudiante estudiante, out int estudianteId) 
        {
            bool result = true;



            estudianteId = estudiante.PersonaId;
            return result;
        }
    }
}
