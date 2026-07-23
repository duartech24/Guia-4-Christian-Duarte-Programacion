Random random = new Random();
char respuesta;

do
{
    Console.WriteLine("--- PIEDRA, PAPEL O TIJERA ---");
    Console.WriteLine("1. Piedra");
    Console.WriteLine("2. Papel");
    Console.WriteLine("3. Tijera");
    Console.Write("Seleccione su opcion (1-3): ");
    int opcionUsuario = Convert.ToInt32(Console.ReadLine());

    if (opcionUsuario >= 1 && opcionUsuario <= 3)
    {
        int opcionComp = random.Next(1, 4);

        Console.WriteLine();
        switch (opcionComp)
        {
            case 1:
                Console.WriteLine("La computadora eligio: Piedra");
                break;
            case 2:
                Console.WriteLine("La computadora eligio: Papel");
                break;
            case 3:
                Console.WriteLine("La computadora eligio: Tijera");
                break;
        }

        if (opcionUsuario == opcionComp)
        {
            Console.WriteLine("¡Es un empate!");
        }
        else if ((opcionUsuario == 1 && opcionComp == 3) ||
                 (opcionUsuario == 2 && opcionComp == 1) ||
                 (opcionUsuario == 3 && opcionComp == 2))
        {
            Console.WriteLine("¡Felicidades, ganaste!");
        }
        else
        {
            Console.WriteLine("¡Gana la computadora!");
        }
    }
    else
    {
        Console.WriteLine("Opcion no valida.");
    }

    Console.WriteLine();
    Console.Write("Desea jugar de nuevo? (s/n): ");
    respuesta = Console.ReadKey().KeyChar;
    Console.WriteLine("\n");

} while (respuesta != 'n' && respuesta != 'N');
    