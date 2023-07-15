

CalcularHoraTrabajador();


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

    Console.WriteLine($"El sueldo del trabajdor es: {sueldo}");

}

static void CalcularNumeros()
{
    // Declaraciones de la variables //
    int num1 = 0;
    int num2 = 0;
    int suma = 0;
    int producto = 0;
    string linea = string.Empty;

    Console.WriteLine(" ---------Ingrese los numeros a calcular -----------");

    Console.WriteLine("Ingrese el primer numero: ");
    linea = Console.ReadLine();
    num1 = int.Parse(linea);

    Console.WriteLine("Ingrese el segundo numero: ");
    linea = Console.ReadLine();
    num2 = int.Parse(linea);

    suma = (num1 + num2); // Calcular la suma de los dos numeros //

    producto = (num1 * num2);

    Console.WriteLine($"La suma es: {suma} y el producto es: {producto}");

}