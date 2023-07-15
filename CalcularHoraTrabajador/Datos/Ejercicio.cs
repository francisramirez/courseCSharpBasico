

namespace CalcularHoraTrabajador.Datos
{
    public static class Ejercicio
    {
        public static void CalcularHoraTrabajador()
        {
            // Declarar las variables

            decimal horasTrabajadas = 0;
            decimal costoPorHora = 0;
            decimal sueldo = 0;
            string linea = string.Empty;

            Console.WriteLine(" ---------Calcular trabajadas -----------");


            Console.WriteLine("Ingrese las horas trabajadas: ");
            linea = Console.ReadLine();
            horasTrabajadas = decimal.Parse(linea);

            Console.WriteLine("Ingrese el costo por hora: ");
            linea = Console.ReadLine();
            costoPorHora = decimal.Parse(linea);

            sueldo = (horasTrabajadas * costoPorHora);

            Console.WriteLine($"El sueldo del trabajdor es: {sueldo}");

        }
    }
}
