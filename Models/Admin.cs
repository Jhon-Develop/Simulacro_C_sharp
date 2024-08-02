using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro_C_.Models
{
    public class Admin
    {
        public static List<Driver> Drivers { get; set; } =
        [
            new Driver("Luisa", "Areiza", "DNI", "123456789", new DateOnly(1990, 1, 1), "email@email.com", "123456789", "Calle de la ciudad", "N° de placa", "B2", 2),
            new Driver("Carlos", "Taborda", "DNI", "123456789", new DateOnly(1990, 1, 1), "email@email.com", "123456789", "Calle de la ciudad", "N° de placa", "B2", 1),
            new Driver("Juan", "Perez", "DNI", "123456789", new DateOnly(1990, 1, 1), "email@email.com", "123456789", "Calle de la ciudad", "N° de placa", "B2", 1),
            new Driver("Leison", "Arbelaez", "DNI", "123456789", new DateOnly(1990, 1, 1), "email@email.com", "123456789", "Calle de la ciudad", "N° de placa", "A2", 1),
            new Driver("Andres", "Usuga", "DNI", "123456789", new DateOnly(1990, 1, 1), "email@email.com", "123456789", "Calle de la ciudad", "N° de placa", "A2", 1),
            new Driver("Brayan", "Mosquera", "DNI", "123456789", new DateOnly(1990, 1, 1), "email@email.com", "123456789", "Calle de la ciudad", "N° de placa", "A2", 1),
            new Driver("Samuel", "Comez", "DNI", "123456789", new DateOnly(1990, 1, 1), "email@email.com", "123456789", "Calle de la ciudad", "N° de placa", "A2", 1),
        ];
        public static List<Vehicle> Vehicles { get; set; } =
        [
            new Vehicle(1, "ABC123", "C", "camioneta", "987654321", 2, new Driver("Luisa", "Areiza", "DNI", "123456789", new DateOnly(1990, 1, 1), "email@email.com", "123456789", "Calle de la ciudad", "N° de placa", "A", 1)),
            new Vehicle(2, "ABC123", "C", "microbus", "987654321", 2, new Driver("Carlos", "Taborda", "DNI", "123456789", new DateOnly(1990, 1, 1), "email@email.com", "123456789", "Calle de la ciudad", "N° de placa", "A", 1)),
            new Vehicle(3, "ABC123", "C", "carro", "987654321", 2, new Driver("Juan", "Perez", "DNI", "123456789", new DateOnly(1990, 1, 1), "email@email.com", "123456789", "Calle de la ciudad", "N° de placa", "A", 1)),
            new Vehicle(4, "ABC123", "C", "Moto", "987654321", 2, new Driver("Leison", "Arbelaez", "DNI", "123456789", new DateOnly(1990, 1, 1), "email@email.com", "123456789", "Calle de la ciudad", "N° de placa", "A", 1)),
            new Vehicle(5, "ABC123", "C", "camioneta", "987654321", 2, new Driver("Brayan", "Mosquera", "DNI", "123456789", new DateOnly(1990, 1, 1), "email@email.com", "123456789", "Calle de la ciudad", "N° de placa", "A", 1)),
            new Vehicle(6, "ABC123", "C", "Moto", "987654321", 2, new Driver("Andres", "Usuga", "DNI", "123456789", new DateOnly(1990, 1, 1), "email@email.com", "123456789", "Calle de la ciudad", "N° de placa", "A", 1)),
            new Vehicle(7, "ABC123", "C", "microbus", "987654321", 2, new Driver("Samuel", "Comez", "DNI", "123456789", new DateOnly(1990, 1, 1), "email@email.com", "123456789", "Calle de la ciudad", "N° de placa", "A", 1)),
        ];
        public static List<Customer> Customers { get; set; } =
        [
            new Customer("Luisa", "Areiza", "DNI", "123456789", new DateOnly(1990, 1, 1), "email@email.com", "123456789", "Calle de la ciudad", "Diamante", "Mastercard"),
            new Customer("Carlos", "Taborda", "DNI", "123456789", new DateOnly(1990, 1, 1), "email@email.com", "123456789", "Calle de la ciudad", "Plata", "Paypal"),
            new Customer("Juan", "Perez", "DNI", "123456789", new DateOnly(1990, 1, 1), "email@email.com", "123456789", "Calle de la ciudad", "Oro", "Visa"),
            new Customer("Leison", "Arbelaez", "DNI", "123456789", new DateOnly(1990, 1, 1), "email@email.com", "123456789", "Calle de la ciudad", "Plata", "Paypal"),
            new Customer("Andres", "Usuga", "DNI", "123456789", new DateOnly(1990, 1, 1), "email@email.com", "123456789", "Calle de la ciudad", "Plata", "Bamcolombia"),
            new Customer("Brayan", "Mosquera", "DNI", "123456789", new DateOnly(1990, 1, 1), "email@email.com", "123456789", "Calle de la ciudad", "Bronce", "Paypal"),
            new Customer("Samuel", "Comez", "DNI", "123456789", new DateOnly(1990, 1, 1), "email@email.com", "123456789", "Calle de la ciudad", "Plata", "Nequi"),

        ];

        // Funciones solicitadas en el proyecto
        public void DeleteVehicle(int id)
        {
            Vehicle? vehicle = Vehicles.Find(i => i.Id == id);
            if (vehicle != null)
            {
                Vehicles.Remove(vehicle);

                Console.WriteLine("");
                Console.WriteLine("Vehiculo eliminado con éxito!");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("El vehículo no existe");
            }
        }

        // Funciones Adicionales
        // Vehiculos
        public void AddVehiculo()
        {
            int id = Vehicles.Count + 1;
            string placa = Setting.InputString("Introduzca el placa del vehículo => ");
            string type = Setting.InputString("Introduzca el tipo del vehículo => ");
            string engineNumber = Setting.InputString("Introduzca el número de motor del vehículo => ");
            string serialNumber = Setting.InputString("Introduzca el número de serie del vehículo => ");
            byte peopleCapacity = Convert.ToByte(Setting.InputString("Introduzca la capacidad de personas del vehículo => "));
            string ownerName = Setting.InputString("Introduzca el nombre del conductor del vehículo => ");

            Driver? owner = Drivers.Find(d => d.GetName() == ownerName) ?? AddDriver();
            Vehicles.Add(new Vehicle(id, placa, type, engineNumber, serialNumber, peopleCapacity, owner));

            Console.WriteLine("");
            Console.WriteLine("Vehículo añadido con éxito!");
            Console.WriteLine("");
        }

        public void ShowVehicles()
        {
            Console.WriteLine("ID\tPlaca\tTipo\tNúmero de Motor\tNúmero de Serie\tPersonas Capacidad\tConductor");
            foreach (Vehicle vehicle in Vehicles)
            {
                Console.WriteLine($"{vehicle.Id}\t{vehicle.Placa}\t{vehicle.Type}\t{vehicle.EngineNumber}\t{vehicle.SerialNumber}\t{vehicle.PeopleCapacity}\t{vehicle.Owner.GetName()}");
            }
        }

        // Drivers
        public Driver AddDriver()
        {
            string name = Setting.InputString("Introduzca el nombre del conductor => ");
            string lastName = Setting.InputString("Introduzca el apellido del conductor => ");
            string typeDocument = Setting.InputString("Introduzca el tipo de documento del conductor => ");
            string identificationNumber = Setting.InputString("Introduzca el número de identificación del conductor => ");
            DateOnly birthDate = Setting.InputDateOnly("Introduzca la fecha de nacimiento del conductor => ");
            string email = Setting.InputString("Introduzca el email del conductor => ");
            string phoneNumber = Setting.InputString("Introduzca el número de teléfono del conductor => ");
            string address = Setting.InputString("Introduzca la dirección del conductor => ");
            string licenseNumer = Setting.InputString("Introduzca el número de licencia del conductor => ");
            string licenseCategory = Setting.InputString("Introduzca la categoría de licencia del conductor => ");
            int drivingExperience = Setting.InputInt("Introduzca la experiencia de conducción del conductor => ");

            Driver newDriver = new Driver(name, lastName, typeDocument, identificationNumber, birthDate, email, phoneNumber, address, licenseNumer, licenseCategory, drivingExperience);

            Drivers.Add(newDriver);

            Console.WriteLine("");
            Console.WriteLine("Conductor añadido con éxito!");
            Console.WriteLine("");
            return newDriver;
        }

        public void ShowDrivers()
        {
            Console.WriteLine("ID\tNombre\tApellido\tTipo de documento\tNúmero de identificación\tFecha de nacimiento\tEmail\tTeléfono\tDirección\tLicencia Número\tLicencia Categoría\tExperiencia Conducción");
            foreach (Driver driver in Drivers)
            {
                Console.WriteLine($"{driver.GetName()}\t{driver.GetLastName()}\t{driver.GetTypeDocument()}\t{driver.GetIdentificationNumber()}\t{driver.GetBirthDate()}\t{driver.GetEmail()}\t{driver.GetPhoneNumber()}\t{driver.GetAddress()}\t{driver.LicenseNumber}\t{driver.LicenseCategory}\t{driver.DrivingExperience}");
            }
        }
    }
}