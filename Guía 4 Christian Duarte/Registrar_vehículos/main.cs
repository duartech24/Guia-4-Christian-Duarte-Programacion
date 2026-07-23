using System;

class Program
{
    static string[,] vehiculos = new string[10, 3];

    static void Main(string[] args)
    {
        int opcion;

        do
        {
            Console.Clear();
            Console.WriteLine("------ MENU ------");
            Console.WriteLine("1. Registrar vehiculo");
            Console.WriteLine("2. Mostrar vehiculos");
            Console.WriteLine("3. Actualizar vehiculo");
            Console.WriteLine("4. Eliminar vehiculo");
            Console.WriteLine("5. Salir");
            Console.Write("Opcion: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("===REGISTRAR VEHICULO===");
                    Registrar();
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("===MOSTRAR VEHICULOS===");
                    MostrarE();
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("===ACTUALIZAR VEHICULO===");
                    Actualizar();
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine("===ELIMINAR VEHICULO===");
                    Eliminar();
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    break;
            }

        } while (opcion != 5);
    }

    // Método Registrar Vehículos
    static void Registrar()
    {
        for (int i = 0; i < 1; i++)
        {
            if (string.IsNullOrEmpty(vehiculos[i, 0]))
            {
                Console.Write("Numero de placa: ");
                vehiculos[i, 0] = Console.ReadLine();

                Console.Write("Nombre del propietario: ");
                vehiculos[i, 1] = Console.ReadLine();

                Console.Write("Marca del vehiculo: ");
                vehiculos[i, 2] = Console.ReadLine();

                Console.WriteLine("Vehiculo registrado.");
            }
        }

        Console.WriteLine("Matriz llena.");
    }

    // Método Mostrar Vehículos
    static void MostrarE()
    {
        Console.WriteLine("PLACA\tPROPIETARIO\tMARCA");

        for (int i = 0; i < 10; i++)
        {
            if (!string.IsNullOrEmpty(vehiculos[i, 0]))
            {
                Console.WriteLine(vehiculos[i, 0] + "\t" +
                                  vehiculos[i, 1] + "\t" +
                                  vehiculos[i, 2]);
            }
        }
    }

    // Método Actualizar Vehículos
    static void Actualizar()
    {
        Console.Write("Numero de placa a buscar: ");
        string placa = Console.ReadLine();

        for (int i = 0; i < 10; i++)
        {
            if (vehiculos[i, 0] == placa)
            {
                Console.Write("Nuevo nombre del propietario: ");
                vehiculos[i, 1] = Console.ReadLine();

                Console.Write("Nueva marca del vehiculo: ");
                vehiculos[i, 2] = Console.ReadLine();

                Console.WriteLine("Registro actualizado.");
            }
        }
    }

    // Método Eliminar Vehículos
    static void Eliminar()
    {
        Console.Write("Numero de placa a eliminar: ");
        string placa = Console.ReadLine();

        for (int i = 0; i < 10; i++)
        {
            if (vehiculos[i, 0] == placa)
            {
                vehiculos[i, 0] = "";
                vehiculos[i, 1] = "";
                vehiculos[i, 2] = "";

                Console.WriteLine("Registro eliminado.");
            }
        }
    }
}