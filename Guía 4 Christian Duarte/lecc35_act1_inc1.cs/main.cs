char respuesta;
do
{
    Console.Write("Ingrese la cantidad en moneda local: ");
    double cantidadLocal = Convert.ToDouble(Console.ReadLine());

    double usd = cantidadLocal * 0.13;
    double eur = cantidadLocal * 0.12;
    double mxn = cantidadLocal * 2.50;
    double gbp = cantidadLocal * 0.10;
    double jpy = cantidadLocal * 19.50;

    Console.WriteLine("\n--- EQUIVALENCIAS ---");
    Console.WriteLine($"1. Estados Unidos (USD): {usd:F2}");
    Console.WriteLine($"2. Union Europea (EUR): {eur:F2}");
    Console.WriteLine($"3. Mexico (MXN): {mxn:F2}");
    Console.WriteLine($"4. Reino Unido (GBP): {gbp:F2}");
    Console.WriteLine($"5. Japon (JPY): {jpy:F2}");

    Console.WriteLine();
    Console.Write("Desea convertir otra cantidad? (s/n): ");
    respuesta = Console.ReadKey().KeyChar;
    Console.WriteLine("\n");

} while (respuesta != 'n' && respuesta != 'N');