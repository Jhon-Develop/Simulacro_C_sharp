using Simulacro_C_.Models;

namespace Simulacro_C_;

class Program
{
    static void Main(string[] args)
    {
        bool menuOpen = true;
        while (menuOpen)
        {
            Console.WriteLine($"{Setting.Header("TransRiwi")}");
            Console.WriteLine(@"
            1. Conductores.
            2. Vehiculos.
            3. Clientes.
            4. Salir.
            ");
            int option = Setting.InputInt("Elija una opción => ");
            switch (option)
            {
                case 1:
                    Console.WriteLine($"{Setting.Header("")}");
                break;
                case 2:
                    Console.WriteLine($"{Setting.Header("")}");
                break;
                case 3:
                    Console.WriteLine($"{Setting.Header("")}");
                break;
                case 4:
                    menuOpen = false;
                break;
                default:
                    Console.WriteLine("Opción no válida"); break;
            }
        }
    }
}