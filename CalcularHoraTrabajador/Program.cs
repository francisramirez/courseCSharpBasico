using CalcularHoraTrabajador.Datos;
using CalcularHoraTrabajador.Entities;

Estudiante estudiante = new Estudiante();

estudiante.CargarDatos();

var estudiantes = estudiante.GetEstudiantes();


EstudianteDb estudianteDb = new EstudianteDb();


int estId = 0;

var result = estudianteDb.GuardarEstudiante(estudiante, out estId);


if (result)
{
    Console.WriteLine("estudiante agregado");
    //Obtener los datos del estudiante //
    var est = estudianteDb.GetEstudiante(estId);

    // Mostramo la informacion del estudiante.//
}

//estudianteDb.GetEstudiantes()

//Console.WriteLine()

foreach (var est in estudiantes)
{
    Console.WriteLine($"{est.Nombre} {est.Apellido}");
}


//};


//Persona persona = new Persona();


//Estudiante estudiante = new Estudiante();



//persona.Color = Colores.Black;
//persona.Caminar();

//persona.Hablar();













//CalcularHoraTrabajador();


//Calcular calcular = new Calcular();

//calcular.CalcularConSwithNotas();

//Contar100();
//CalcularPromeridoYSuma();
//CalcularNotas();

//CalcularPromeridoYSumaWhile();

//CalcularLogitudLote();
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

static void Contar100()
{
    for (int i = 1; i <= 100; i++)
    {
        Console.WriteLine($"{i}");

        //if (i < 20 )
        //{
        //   // realizar x cosa
        //}
    }
}
/*
 Realizar un programa que permita la carga de 10 valores por teclados y luego muestre la suma de los valores
 introduccidos y su promedio. Se debe desarrollar utilizando la estructura for ..
 */
static void CalcularPromeridoYSuma()
{
    // Declaramos las variables
    int suma = 0;
    int promedio = 0;
    int valor = 0;

    string linea = string.Empty;
    int cantidad = 10;

    for (int i = 1; i <= cantidad; i++)
    {
        Console.WriteLine("Digite el valor: ");
        linea = Console.ReadLine();

        if (!int.TryParse(linea, out int myvalor))
            Console.WriteLine("El valor introduccido es invalido..");
        else
        {
            valor = myvalor;

            suma += valor;
        }
    }

    promedio = (suma / cantidad);

    Console.WriteLine($"La suma es: {suma} y el promedio es: {promedio}");

}
/*
 Realizar un programa que lea 10 notas de los estudiantes e informe cuantos tienen mayores 7 o iguales a 7 y 
 cuantos menores. Se debe desarrollar utilizando la estructura for ..
 */
static void CalcularNotas()
{
    // Declaracion de variables //
    int nota = 0;
    int aprobados = 0;
    int reprobados = 0;
    string linea = string.Empty;
    int cantidad = 10;

    for (int i = 1; i <= cantidad; i++)
    {
        Console.WriteLine("Digite el valor de la nota: ");
        linea = Console.ReadLine();

        if (!int.TryParse(linea, out int mynota))
            Console.WriteLine("El valor de la nota introducida es invalida.");
        else
        {
            nota = mynota;

            if (nota >= 7) // cantidad aprobados
            {
                aprobados += 1;
            }
            else  // cantidad reprobados
            {
                reprobados += 1;
            }
        }
    }

    // Imprimirlos resultados //

    Console.WriteLine($"Cantidad de aprobados: {aprobados} y Cantidad de reprobads: {reprobados}");

}


static void CalcularPromeridoYSumaWhile()
{
    // Declaramos las variables
    int suma = 0;
    int promedio = 0;
    int valor = 0;
    string linea = string.Empty;
    int cantidad = 5;

    int i = 0;

    while (i <= cantidad)
    {
        Console.WriteLine("Digite el valor: ");
        linea = Console.ReadLine();


        if (!int.TryParse(linea, out int myvalor))
            Console.WriteLine("El valor introduccido es invalido..");

        else
        {
            valor = myvalor;

            suma += valor;

            i += 1;
        }

    }

    promedio = (suma / cantidad);

    Console.WriteLine($"La suma es: {suma} y el promedio es: {promedio}");
}


/*
 Una planta que fabrica perfiles de hierro posee un lote de n piezas.
Realizar un programa que pida ingresar la cantidad de piezas y luego ingrese la longtiud de cada perfil, 
tomando en cuenta que cada pieza cuya longitud esté comprendia en un rango de 1.20 y 1.30 son validas. 
Imprimir por pantalla la cantidad de piezas validas que hay en el lote.
 */

static void CalcularLogitudLote() 
{

    // Declaracion de las variables //
    int contador = 0; 
    int cantidad = 0;
    double largo = 0;
    string linea = string.Empty;
    int cantidadIngresada = 0;

    // Solicitar la cantidad de piezeas //
    Console.WriteLine("Digite la cantidad de piezas");
    linea = Console.ReadLine();

    if (!int.TryParse(linea, out int myIndex))
       Console.WriteLine("Cantidad de piezas invalida..");

    else
    {
        cantidadIngresada = myIndex;


        while (contador <= cantidadIngresada)
        {
            Console.WriteLine("Digite la medida de la pieza");
            linea = Console.ReadLine();

            
            if (double.TryParse(linea, out double myLenght))
            {
                largo = myLenght;

                if (largo >= 1.20 && largo <= 1.30)
                    cantidad += 1;
                
            }
            contador += 1;
        }

        // Imprimir la cantidad de  piezas válidas //
        Console.WriteLine($"La cantidad de piezas que son válidas: { cantidad }");
    }

}