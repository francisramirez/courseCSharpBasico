using CalcularHoraTrabajador.Enums;

namespace CalcularHoraTrabajador.Datos
{
    public abstract class Persona
    {
        List<Persona> personas;
        public Persona(string nombre)
        {

            this.personas = new List<Persona>();
            this.Nombre = nombre;

            // cargar los datos de la persona //


        }
        public Persona()
        {
          

            //this.CargarDatos();
        }

        #region "Variables"
        private string? _myVar;
        #endregion

        #region "Atributos"

        public string? TipoPiel { get; set; }
        public Colores Color { get; set; }
        public string? Estado { get; set; }
        #endregion

        #region"Propiedades"

        public int PersonaId { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Correo { get; set; }
        public string? Telefono { get; set; }

        public List<Persona> Personas { get { return this.personas; } }

        public string NombreCompleto { get { return string.Concat(this.Nombre, " ", this.Apellido); } }
        #endregion

        public abstract void Caminar();

        public void Hablar()
        {

            List<Persona> personas = new List<Persona>();
           
            Console.WriteLine($" {this.Nombre} {this.Apellido} esta hablando.");
        }

        public abstract void CargarDatos();
         
    }
}
