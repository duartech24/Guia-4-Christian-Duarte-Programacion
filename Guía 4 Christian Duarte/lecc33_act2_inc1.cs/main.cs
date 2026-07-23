Console.Write("Ingrese una frase: ");
string frase = Console.ReadLine();

char[] caracteres = frase.ToCharArray();
Array.Reverse(caracteres);
string fraseInvertida = new string(caracteres);

Console.WriteLine("\n--- RESULTADO ---");
Console.WriteLine($"Frase invertida: {fraseInvertida}");