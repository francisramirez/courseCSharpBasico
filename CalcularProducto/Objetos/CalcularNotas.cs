using System;

namespace CalcularProducto.Objetos
{
    public class Calcular
    {
        public void CalcularNotas()
        {
            int cantNota = 3;
            int nota1 = 0;
            int nota2 = 0;
            int nota3 = 0;
            string linea;
            int promedio = 0;

            Console.WriteLine("Ingrese la nota 1: ");
            linea = Console.ReadLine();

            // Nota 1 //
            if (int.TryParse(linea, out int myNota1))
            {
                nota1 = myNota1;
            }
            else
            {
                Console.WriteLine($"La nota 1: {linea} es inválida");
                return;
            }
          
            Console.WriteLine("Ingrese la nota 2: ");
            linea = Console.ReadLine();
            
            // Nota 2 //
            if (int.TryParse(linea, out int myNota2))
            {
                nota2 = myNota2;
            }
            else
            {
                Console.WriteLine($"La nota 2: {linea} es inválida");
                return;
            }

            Console.WriteLine("Ingrese la nota 3: ");
            linea = Console.ReadLine();

            // Nota 3 //
            if (int.TryParse(linea, out int myNota3))
            {
                nota3 = myNota3;
            }
            else
            {
                Console.WriteLine($"La nota 3: {linea} es inválida");
                return;
            }

            promedio = (nota1 + nota2 + nota3) / cantNota;

            if (promedio >= 7)
            {
               
                Console.WriteLine("Bien");

            }
            else if (promedio >= 4)
            {
               
                Console.WriteLine("Bien");
            }
            else
            {
               
                Console.WriteLine("Reprobado.");
            }


        }
    }
}
