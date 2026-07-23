double metros, resultado;
int opcion;

Console.Write("Ingrese la cantidad en metros: ");

metros = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("\n--- MENÚ DE OPCIONES ---");
Console.WriteLine("1. Convertir a Milímetros (mm)");
Console.WriteLine("2. Convertir a Centímetros (cm)");
Console.WriteLine("3. Convertir a Decímetros (dm)");
Console.WriteLine("4. Convertir a Hectómetros (hm)");
Console.WriteLine("5. Convertir a Kilómetros (km)");
Console.Write("Seleccione una opción (1-5): ");
opcion = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(); 

switch (opcion)
{
    case 1:
        resultado = metros * 1000;
        Console.WriteLine($"{metros} metros equivalen a {resultado} milímetros.");
        break;
    case 2:
        resultado = metros * 100;
        Console.WriteLine($"{metros} metros equivalen a {resultado} centímetros.");
        break;
    case 3:
        resultado = metros * 10;
        Console.WriteLine($"{metros} metros equivalen a {resultado} decímetros.");
        break;
    case 4:
        resultado = metros / 100;
        Console.WriteLine($"{metros} metros equivalen a {resultado} hectómetros.");
        break;
    case 5:
        resultado = metros / 1000;
        Console.WriteLine($"{metros} metros equivalen a {resultado} kilómetros.");
        break;
    default:
        Console.WriteLine("Opción no válida. Por favor, intente de nuevo.");
        break;
}

Console.WriteLine("\nPresione cualquier tecla para salir...");
Console.ReadKey();
        