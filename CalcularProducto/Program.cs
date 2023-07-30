using CalcularProducto.Objetos;
using System;


namespace CalcularProducto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // CalcularNumeros();
            //CalcularHoraTrabajador();

            Calcular calcular = new Calcular();
            calcular.CalcularNotas();


        }

        /// <summary>
        /// Calcular dos numeros
        /// </summary>
        static void CalcularNumeros() 
        {
            // Declaraciones de la variables //
            int num1 = 0;
            int num2 = 0;
            int suma = 0;
            int producto = 0;
            string linea = null;
            
         
            Console.WriteLine(" ---------Ingrese los numeros a calcular -----------");

            Console.WriteLine("Ingrese el primer numero: ");
            linea = Console.ReadLine();

           
            if (int.TryParse(linea, out int myNum))
                num1 = myNum;
            else 
            {
                Console.WriteLine($"El valor: { linea } es inválido");
                return;
            }
               

            Console.WriteLine("Ingrese el segundo numero: ");
            linea = Console.ReadLine();

            if (int.TryParse(linea, out int myNum2))
                num2 = myNum2;
            else
            {
                Console.WriteLine($"El valor: {linea} es inválido");
                return;
            }

            suma = (num1 + num2); // Calcular la suma de los dos numeros //

            if (suma >= 200)
            {
                // realizar x cosa //
            }
            producto = (num1 * num2);

            Console.WriteLine($"La suma es: { suma } y el producto es: { producto }");

        }
        /// <summary>
        /// Calcular hora trabajador
        /// </summary>
        static void CalcularHoraTrabajador()
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

            Console.WriteLine($"El sueldo del trabajdor es: { sueldo }");

        }
    }
}
