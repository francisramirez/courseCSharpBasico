using CalcularHoraTrabajador.Datos;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
//CalcularHoraTrabajador();


//Calcular calcular = new Calcular();

//calcular.CalcularConSwithNotas();

GetSortedList();

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

static void GetSortedList() 
{
    var students = new List<Student>() 
    {
        new Student(){ EmployeeId = 1, Email="francis@gmail.com", FirstName="francis", LastName="ramirez" },
        new Student(){ EmployeeId = 2, Email="jose@gmail.com", FirstName="jose", LastName="rodriguez" },
        new Student(){ EmployeeId = 3, Email="armando@gmail.com", FirstName="armando", LastName="perez" },
        new Student(){ EmployeeId = 4, Email="zapata@gmail.com", FirstName="zacarias", LastName="zapatas" },
    };

    var st = students.Find(cd => cd.EmployeeId == 2);

    var value = students.BinarySearch(st);

    //foreach (var item in students)
    //{
    //    Console.WriteLine(item.FirstName);
    //}

    //// Create a set of strings  
    //var names = new SortedSet<string>();
    //names.Add("Sonoo");
    //names.Add("Ankit");
    //names.Add("Peter");
    //names.Add("Irfan");
    //names.Add("Ankit");//will not be added  

    //// Iterate SortedSet elements using foreach loop  
    //foreach (var name in names)
    //{
    //    Console.WriteLine(name);
    //}
}

public class Student : IComparable
{
    public int EmployeeId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }

    public int CompareTo(object? obj)
    {
        var result = 0;
        if (obj != null)
        {
            result = 1;
            return result;
        }
        return result;
    }
}
