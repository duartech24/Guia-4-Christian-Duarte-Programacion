Console.WriteLine("--- MENU DE CONVERSION ---");
Console.WriteLine("a. Convertir de Decimal a Binario");
Console.WriteLine("b. Convertir de Binario a Decimal");
Console.Write("Seleccione una opcion (a/b): ");
char opcion = Console.ReadKey().KeyChar;
Console.WriteLine("\n");

switch (char.ToLower(opcion))
{
    case 'a':
        Console.Write("Ingrese un numero decimal entero positivo: ");
        int numDecimal = Convert.ToInt32(Console.ReadLine());
        string binario = Convert.ToString(numDecimal, 2);
        Console.WriteLine($"El numero {numDecimal} en binario es: {binario}");
        break;

    case 'b':
        Console.Write("Ingrese un numero binario: ");
        string numBinario = Console.ReadLine();
        int resultadoDecimal = Convert.ToInt32(numBinario, 2);
        Console.WriteLine($"El numero binario {numBinario} en decimal es: {resultadoDecimal}");
        break;

    default:
        Console.WriteLine("Opcion no valida.");
        break;
}