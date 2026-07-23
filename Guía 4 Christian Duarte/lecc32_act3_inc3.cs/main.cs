Console.Write("Ingrese la medida del primer lado: ");
double lado1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la medida del segundo lado: ");
double lado2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la medida del tercer lado: ");
double lado3 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("\n--- RESULTADO ---");

if ((lado1 + lado2 > lado3) && (lado1 + lado3 > lado2) && (lado2 + lado3 > lado1))
{
    if (lado1 == lado2 && lado2 == lado3)
    {
        Console.WriteLine("El triangulo es Equilatero.");
    }
    else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
    {
        Console.WriteLine("El triangulo es Isosceles.");
    }
    else
    {
        Console.WriteLine("El triangulo es Escaleno.");
    }
}
else
{
    Console.WriteLine("Las medidas ingresadas no forman un triangulo valido.");
}