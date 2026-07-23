using System;

class Program
{
    static string[,] productos = new string[10, 3];

    static void Main(string[] args)
    {
        int opcion;

        do
        {
            Console.Clear();
            Console.WriteLine("===== MENU PRINCIPAL =====");
            Console.WriteLine("1. Registrar Producto");
            Console.WriteLine("2. Mostrar Producto");
            Console.WriteLine("3. Actualizar Producto");
            Console.WriteLine("4. Eliminar Producto");
            Console.WriteLine("5. Salir");
            Console.Write("Opcion: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("=== REGISTRAR PRODUCTO ===");
                    Registrar();
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("=== MOSTRAR PRODUCTOS ===");
                    MostrarE();
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("=== ACTUALIZAR PRODUCTOS ===");
                    Actualizar();
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine("=== ELIMINAR PRODUCTOS ===");
                    Eliminar();
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    break;
            }

        } while (opcion != 5);
    }

    // Método Registrar Productos
    static void Registrar()
    {
        for (int i = 0; i < 10; i++)
        {
            if (string.IsNullOrEmpty(productos[i, 0]))
            {
                Console.Write("Codigo: ");
                productos[i, 0] = Console.ReadLine();

                Console.Write("Nombre: ");
                productos[i, 1] = Console.ReadLine();

                Console.Write("Cantidad en existencia: ");
                productos[i, 2] = Console.ReadLine();

                Console.WriteLine("Producto registrado.");
            }
        }

        Console.WriteLine("Matriz llena.");
    }

    // Método Mostrar Productos
    static void MostrarE()
    {
        Console.WriteLine("CODIGO\tNOMBRE\tCANTIDAD EN EXISTENCIA");

        for (int i = 0; i < 10; i++)
        {
            if (!string.IsNullOrEmpty(productos[i, 0]))
            {
                Console.WriteLine(productos[i, 0] + "\t" +
                                  productos[i, 1] + "\t" +
                                  productos[i, 2]);
            }
        }
    }

    // Método Actualizar Productos
    static void Actualizar()
    {
        Console.Write("Codigo a buscar: ");
        string codigo = Console.ReadLine();

        for (int i = 0; i < 10; i++)
        {
            if (productos[i, 0] == codigo)
            {
                Console.Write("Nuevo nombre: ");
                productos[i, 1] = Console.ReadLine();

                Console.Write("Nueva cantidad en existencia: ");
                productos[i, 2] = Console.ReadLine();

                Console.WriteLine("Registro actualizado.");
            }
        }
    }

    // Método Eliminar Productos
    static void Eliminar()
    {
        Console.Write("Codigo a eliminar: ");
        string codigo = Console.ReadLine();

        for (int i = 0; i < 10; i++)
        {
            if (productos[i, 0] == codigo)
            {
                productos[i, 0] = "";
                productos[i, 1] = "";
                productos[i, 2] = "";

                Console.WriteLine("Registro eliminado.");
            }
        }
    }
}