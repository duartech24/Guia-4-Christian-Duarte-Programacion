string[] nombres = new string[10];
string[] telefonos = new string[10];

Console.WriteLine("--- REGISTRO DE 10 CONTACTOS ---");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Contacto {i + 1}:");
    Console.Write("Ingrese el nombre: ");
    nombres[i] = Console.ReadLine();
    Console.Write("Ingrese el telefono: ");
    telefonos[i] = Console.ReadLine();
}

Console.WriteLine();
Console.Write("Ingrese la posicion del contacto a consultar (1 a 10): ");
int posicion = Convert.ToInt32(Console.ReadLine());

if (posicion >= 1 && posicion <= 10)
{
    Console.WriteLine("\n--- DATOS DEL CONTACTO ---");
    Console.WriteLine($"Nombre: {nombres[posicion - 1]}");
    Console.WriteLine($"Telefono: {telefonos[posicion - 1]}");
}
else
{
    Console.WriteLine("Posicion no valida. Debe ser entre 1 y 10.");
}