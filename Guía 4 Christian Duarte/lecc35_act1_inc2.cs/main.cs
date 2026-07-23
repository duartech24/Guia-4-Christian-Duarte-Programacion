Console.Write("Ingrese el precio del producto: ");
double precio = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la cantidad recibida (pago): ");
double pago = Convert.ToDouble(Console.ReadLine());

if (pago < precio)
{
    Console.WriteLine("El dinero ingresado es insuficiente.");
}
else
{
    double cambio = pago - precio;
    Console.WriteLine($"\n--- CAMBIO TOTAL: {cambio:F2} ---");

    int residuo = (int)cambio;
    double monedas = (cambio - residuo) + (residuo % 20);

    int b200 = residuo / 200;
    residuo %= 200;

    int b100 = residuo / 100;
    residuo %= 100;

    int b50 = residuo / 50;
    residuo %= 50;

    int b20 = residuo / 20;
    monedas = (residuo % 20) + (cambio - Math.Truncate(cambio));

    Console.WriteLine($"Billetes de 200: {b200}");
    Console.WriteLine($"Billetes de 100: {b100}");
    Console.WriteLine($"Billetes de 50:  {b50}");
    Console.WriteLine($"Billetes de 20:  {b20}");
    Console.WriteLine($"Monedas / Resto: {monedas:F2}");
}