using Simulacro_C_.Models;

namespace Simulacro_C_;

class Program
{
    static void Main(string[] args)
    {
        Admin admin= new();

        bool menuOpen = true;
        while (menuOpen)
        {
            Console.WriteLine($"{Setting.Header("TransRiwi")}");
            Console.WriteLine(@"
            1. Conductores.
            2. Vehiculos.
            3. Clientes.
            4. Busquedas.
            5. Salir.
            ");
            int option = Setting.InputInt("Elija una opción => ");
            switch (option)
            {
                case 1:
                    Console.WriteLine($"{Setting.Header("Conductores")}");
                    Console.WriteLine(@"
                    1. Añadir conductor.
                    2. Mostrar conductores.
                    3. Actualizar conductor.
                    4. Eliminar conductor.
                    5. Salir.
                    ");
                    int option2 = Setting.InputInt("Elija una opción => ");
                    switch (option2)
                    {
                        case 1:
                            Console.WriteLine($"{Setting.Header("Añadir conductor")}");
                            admin.AddDriver();
                            Setting.FinishOption();
                        break;
                        case 2:
                            Console.WriteLine($"{Setting.Header("Mostrar conductores")}");
                            admin.ShowDrivers();
                            Setting.FinishOption();
                        break;
                        case 3:
                            Console.WriteLine($"{Setting.Header("Actualizar conductor")}");
                            string UpdateName = Setting.InputString("Introduzca el nombre del conductor => ");
                            string UpdateLastName = Setting.InputString("Introduzca el apellido del conductor => ");
                            admin.UpdateDriver(UpdateName, UpdateLastName);
                            Setting.FinishOption();
                        break;
                        case 4:
                            Console.WriteLine($"{Setting.Header("Eliminar conductor")}");
                            string  DeleteName = Setting.InputString("Introduzca el nombre del conductor => ");
                            string DeleteLastName = Setting.InputString("Introduzca el apellido del conductor => ");
                            admin.DeleteDriver(DeleteName, DeleteLastName);
                            Setting.FinishOption();
                        break;
                        case 5:
                            menuOpen = false;
                        break;
                        default:
                            Console.WriteLine("Opción no válida"); break;
                    }
                break;
                case 2:
                    Console.WriteLine($"{Setting.Header("Vehiculos")}");
                    Console.WriteLine(@"
                    1. Añadir vehiculo.
                    2. Mostrar vehiculos.
                    3. Eliminar vehiculo.
                    4. Salir.
                    ");
                    int option3 = Setting.InputInt("Elija una opción => ");
                    switch (option3)
                    {
                        case 1:
                            Console.WriteLine($"{Setting.Header("Añadir vehiculo")}");
                            admin.AddVehicles();
                        break;
                        case 2:
                            Console.WriteLine($"{Setting.Header("Mostrar vehiculos")}");
                            admin.ShowVehicles();
                            break;
                        case 3:
                            Console.WriteLine($"{Setting.Header("Eliminar vehiculo")}");
                            int DeleteId = Setting.InputInt("Introduzca el id del vehiculo que desea eliminar => ");
                            admin.DeleteVehicle(DeleteId);
                            Setting.FinishOption();
                            break;
                        case 4:
                            menuOpen = false;
                            break;
                        default:
                            Console.WriteLine("Opción no válida"); break;
                    }
                break;
                case 3:
                    Console.WriteLine($"{Setting.Header("Clientes")}");
                    Console.WriteLine(@"
                    1. Añadir cliente.
                    2. Mostrar clientes.
                    3. Actualizar cliente.
                    4. Eliminar cliente.
                    5. Salir.
                    ");
                    int option4 = Setting.InputInt("Elija una opción => ");
                    switch (option4)
                    {
                        case 1:
                            Console.WriteLine($"{Setting.Header("Añadir cliente")}"); 
                            admin.AddVehicles();
                            Setting.FinishOption();
                        break;
                        case 2:
                            Console.WriteLine($"{Setting.Header("Mostrar clientes")}");
                            admin.ShowVehicles();
                            Setting.FinishOption();
                        break;
                        case 3:
                            Console.WriteLine($"{Setting.Header("Actualizar cliente")}");
                            string UpdateName = Setting.InputString("Introduzca el nombre del cliente => ");
                            string UpdateLastName = Setting.InputString("Introduzca el apellido del cliente => ");
                            admin.UpdateDriver(UpdateName, UpdateLastName);
                            Setting.FinishOption();
                            break;
                        case 4:
                            Console.WriteLine($"{Setting.Header("Eliminar cliente")}");
                            string DeleteName = Setting.InputString("Introduzca el nombre del cliente => ");
                            string DeleteLastName = Setting.InputString("Introduzca el apellido del cliente => ");
                            admin.DeleteCustomer(DeleteName, DeleteLastName);
                            Setting.FinishOption();
                            break;
                        case 5:
                            menuOpen = false;
                            break;
                        default:
                            Console.WriteLine("Opción no válida"); break;
                    }
                break;
                case 4:
                    Console.WriteLine($"{Setting.Header("Busquedas")}");
                    Console.WriteLine(@"
                    1. Usuarios con más de 30 años.
                    2. Usuarios en orden ascendente en base a su Experiencia Conducción.
                    3. Usuarios que prefieren Paypal.
                    4. Usuarios con licencia A2.
                    5. Salir.
                    ");
                    int option5 = Setting.InputInt("Elija una opción => ");
                    switch (option5)
                    {
                        case 1:
                            Console.WriteLine($"{Setting.Header("Usuarios con más de 30 años")}");
                            if (Admin.Customers.Count > 0)
                            {
                                Console.WriteLine("Usuarios con más de 30 años:");
                                foreach (Customer customer in Admin.Customers)
                                {
                                    if (customer.GetBirthDate().Year > 1990)
                                    {
                                        Console.WriteLine($"{customer.GetName()} {customer.GetLastName()}");
                                    }
                                }
                            }
                        break;
                        case 2:
                            Console.WriteLine($"{Setting.Header("Usuarios en orden ascendente en base a su Experiencia Conducción")}");
                            if (Admin.Drivers.Count > 0)
                            {
                                Console.WriteLine("Usuarios en orden ascendente en base a su Experiencia Conducción:");
                                foreach (Driver driver in Admin.Drivers)
                                {
                                    if (driver.DrivingExperience > 0)
                                    {
                                        Console.WriteLine($"{driver.GetName()} {driver.GetLastName()}");
                                    }
                                }
                            }
                        break;
                        case 3:
                            Console.WriteLine($"{Setting.Header("Usuarios que prefieren Paypal")}");
                            if (Admin.Customers.Count > 0)
                            {
                                Console.WriteLine("Usuarios que prefieren Paypal:");
                                foreach (Customer customer in Admin.Customers)
                                {
                                    if (customer.PreferredPaymentMethod == "Paypal")
                                    {
                                        Console.WriteLine($"{customer.GetName()} {customer.GetLastName()}");
                                    }
                                }
                            }
                        break;
                        case 4:
                            Console.WriteLine($"{Setting.Header("Usuarios con licencia A2")}");
                            if (Admin.Drivers.Count > 0)
                            {
                                Console.WriteLine("Usuarios con licencia A2:");
                                foreach (Driver driver in Admin.Drivers)
                                {
                                    if (driver.LicenseCategory == "A2")
                                    {
                                        Console.WriteLine($"{driver.GetName()} {driver.GetLastName()}");
                                    }
                                }
                            }
                        break;
                        case 5:
                            menuOpen = false;
                            break;
                        default:
                            Console.WriteLine("Opción no válida"); 
                        break;
                    }
                    break;
                case 5:
                    menuOpen = false;
                break;
                default:
                    Console.WriteLine("Opción no válida"); break;
            }
        }
    }
}