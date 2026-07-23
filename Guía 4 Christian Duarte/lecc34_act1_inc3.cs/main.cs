Console.Write("Ingrese la temperatura en grados centigrados: ");
double centigrados = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("\n--- MENU DE CONVERSION ---");
Console.WriteLine("a. Fahrenheit");
Console.WriteLine("b. Celsius");
Console.WriteLine("c. Kelvin");
Console.Write("Seleccione una opcion (a-c): ");
char opcion = Console.ReadKey().KeyChar;
Console.WriteLine("\n");

switch (char.ToLower(opcion))
{
    case 'a':
        double fahrenheit = (centigrados * 9 / 5) + 32;
        Console.WriteLine($"{centigrados} °C equivalen a {fahrenheit} °F.");
        break;

    case 'b':
        Console.WriteLine($"{centigrados} °C equivalen a {centigrados} °C.");
        break;

    case 'c':
        double kelvin = centigrados + 273.15;
        Console.WriteLine($"{centigrados} °C equivalen a {kelvin} K.");
        break;

    default:
        Console.WriteLine("Opcion no valida.");
        break;
}