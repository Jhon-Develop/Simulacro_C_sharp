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
        public void AddVehicles()
        {
            int id = Vehicles.Count + 1;
            string placa = Setting.InputString("Introduzca la placa del vehículo => ");
            string type = Setting.InputString("Introduzca el tipo del vehículo (camioneta, microbus, carro, moto) => ");
            string engineNumber = Setting.InputString("Introduzca el número de motor del vehículo => ");
            string serialNumber = Setting.InputString("Introduzca el número de serie del vehículo => ");
            byte peopleCapacity = Setting.InputByte("Introduzca la capacidad de personas del vehículo => ");
            string ownerName = Setting.InputString("Introduzca el documento del conductor del vehículo => ");


            if ((type == "camioneta" && peopleCapacity <= 4) || (type == "microbus" && peopleCapacity <= 10) || (type == "carro" && peopleCapacity <= 4) || (type == "moto" && peopleCapacity <= 2))
            {
                Driver? owner = Drivers.Find(d => d.GetIdentificationNumber() == ownerName) ?? AddDriver();
                Vehicles.Add(new Vehicle(id, placa, type, engineNumber, serialNumber, peopleCapacity, owner));

                Console.WriteLine("");
                Console.WriteLine("Vehículo añadido con éxito!");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("El tipo del vehículo no es válido");
            }
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

        public void UpdateDriver(string name, string lastName)
        {
            Driver? driver = Drivers.Find(e => e.GetName() == name && e.GetLastName() == lastName);
            if (driver != null)
            {
                string newname = Setting.InputString("Introduzca el nombre del conductor => ");
                string newlastName = Setting.InputString("Introduzca el apellido del conductor => "); ;
                string typeDocument = Setting.InputString("Introduzca el tipo de documento del conductor => ");
                string identificationNumber = Setting.InputString("Introduzca el número de identificación del conductor => ");
                DateOnly birthDate = Setting.InputDateOnly("Introduzca la fecha de nacimiento del conductor => ");
                string email = Setting.InputString("Introduzca el email del conductor => ");
                string phoneNumber = Setting.InputString("Introduzca el número de teléfono del conductor => ");
                string address = Setting.InputString("Introduzca la dirección del conductor => ");
                string licenseNumer = Setting.InputString("Introduzca el número de licencia del conductor => ");
                string licenseCategory = Setting.InputString("Introduzca la categoría de licencia del conductor => ");
                int drivingExperience = Setting.InputInt("Introduzca la experiencia de conducción del conductor => ");

                driver.SetName(string.IsNullOrEmpty(name) ? driver.GetName() : name);
                driver.SetLastName(string.IsNullOrEmpty(lastName) ? driver.GetLastName() : lastName);
                driver.SetTypeDocument(string.IsNullOrEmpty(typeDocument) ? driver.GetTypeDocument() : typeDocument);
                driver.SetIdentificationNumber(string.IsNullOrEmpty(identificationNumber) ? driver.GetIdentificationNumber() : identificationNumber);
                driver.SetBirthDate(birthDate == default ? driver.GetBirthDate() : birthDate);
                driver.SetEmail(string.IsNullOrEmpty(email) ? driver.GetEmail() : email);
                driver.SetPhoneNumber(string.IsNullOrEmpty(phoneNumber) ? driver.GetPhoneNumber() : phoneNumber);
                driver.SetAddress(string.IsNullOrEmpty(address) ? driver.GetAddress() : address);
                driver.LicenseNumber = string.IsNullOrEmpty(licenseNumer) ? driver.LicenseNumber : licenseNumer;
                driver.LicenseCategory = string.IsNullOrEmpty(licenseCategory) ? driver.LicenseCategory : licenseCategory;
                driver.DrivingExperience = drivingExperience == 0 ? driver.DrivingExperience : drivingExperience;

                Console.WriteLine("");
                Console.WriteLine("Datos actualizados con éxito!");
                Console.WriteLine("");
            }
        }

        public void DeleteDriver(string name, string lastName)
        {
            Driver? driver = Drivers.Find(e => e.GetName() == name && e.GetLastName() == lastName);
            if (driver != null)
            {
                Drivers.Remove(driver);

                Console.WriteLine("");
                Console.WriteLine("Conductor eliminado con éxito!");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("El conductor no existe");
            }
        }

        // Customers
        public Customer AddCustomer()
        {
            string name = Setting.InputString("Introduzca el nombre del cliente => ");
            string lastName = Setting.InputString("Introduzca el apellido del cliente => ");
            string typeDocument = Setting.InputString("Introduzca el tipo de documento del cliente => ");
            string identificationNumber = Setting.InputString("Introduzca el número de identificación del cliente => ");
            DateOnly birthDate = Setting.InputDateOnly("Introduzca la fecha de nacimiento del cliente => ");
            string email = Setting.InputString("Introduzca el email del cliente => ");
            string phoneNumber = Setting.InputString("Introduzca el número de teléfono del cliente => ");
            string address = Setting.InputString("Introduzca la dirección del cliente => ");
            string membershipLevel = Setting.InputString("Introduzca la categoría de membresía del cliente => ");
            string preferredPaymentMethod = Setting.InputString("Introduzca el método de pago preferido del cliente => ");

            Customer newCustomer = new Customer(name, lastName, typeDocument, identificationNumber, birthDate, email, phoneNumber, address, membershipLevel, preferredPaymentMethod);

            Customers.Add(newCustomer);

            Console.WriteLine("");
            Console.WriteLine("Cliente añadido con éxito!");
            Console.WriteLine("");
            return newCustomer;
        }

        public void ShowCustomers()
        {
            Console.WriteLine("ID\tNombre\tApellido\tTipo de documento\tNúmero de identificación\tFecha de nacimiento\tEmail\tTeléfono\tDirección\tMembresía\tMétodo de pago preferido");
            foreach (Customer customer in Customers)
            {
                Console.WriteLine($"{customer.GetName()}\t{customer.GetLastName()}\t{customer.GetTypeDocument()}\t{customer.GetIdentificationNumber()}\t{customer.GetBirthDate()}\t{customer.GetEmail()}\t{customer.GetPhoneNumber()}\t{customer.GetAddress()}\t{customer.MembershipLevel}\t{customer.PreferredPaymentMethod}");
            }
        }

        public void UpdateCustomer(string name, string lastName)
        {
            Customer? customer = Customers.Find(e => e.GetName() == name && e.GetLastName() == lastName);
            if (customer != null)
            {
                string newname = Setting.InputString("Introduzca el nombre del cliente => ");
                string newlastName = Setting.InputString("Introduzca el apellido del cliente => "); ;
                string typeDocument = Setting.InputString("Introduzca el tipo de documento del cliente => ");
                string identificationNumber = Setting.InputString("Introduzca el número de identificación del cliente => ");
                DateOnly birthDate = Setting.InputDateOnly("Introduzca la fecha de nacimiento del cliente => ");
                string email = Setting.InputString("Introduzca el email del cliente => ");
                string phoneNumber = Setting.InputString("Introduzca el número de teléfono del cliente => ");
                string address = Setting.InputString("Introduzca la dirección del cliente => ");
                string membershipLevel = Setting.InputString("Introduzca la categoría de membresía del cliente => ");
                string preferredPaymentMethod = Setting.InputString("Introduzca el método de pago preferido del cliente => ");

                customer.SetName(string.IsNullOrEmpty(name) ? customer.GetName() : name);
                customer.SetLastName(string.IsNullOrEmpty(lastName) ? customer.GetLastName() : lastName);
                customer.SetTypeDocument(string.IsNullOrEmpty(typeDocument) ? customer.GetTypeDocument() : typeDocument);
                customer.SetIdentificationNumber(string.IsNullOrEmpty(identificationNumber) ? customer.GetIdentificationNumber() : identificationNumber);
                customer.SetBirthDate(birthDate == default ? customer.GetBirthDate() : birthDate);
                customer.SetEmail(string.IsNullOrEmpty(email) ? customer.GetEmail() : email);
                customer.SetPhoneNumber(string.IsNullOrEmpty(phoneNumber) ? customer.GetPhoneNumber() : phoneNumber);
                customer.SetAddress(string.IsNullOrEmpty(address) ? customer.GetAddress() : address);
                customer.MembershipLevel = string.IsNullOrEmpty(membershipLevel) ? customer.MembershipLevel : membershipLevel;
                customer.PreferredPaymentMethod = string.IsNullOrEmpty(preferredPaymentMethod) ? customer.PreferredPaymentMethod : preferredPaymentMethod;

                Console.WriteLine("");
                Console.WriteLine("Datos actualizados con éxito!");
                Console.WriteLine("");
            }
        }

        public void DeleteCustomer(string name, string lastName)
        {
            Customer? customer = Customers.Find(e => e.GetName() == name && e.GetLastName() == lastName);
            if (customer != null)
            {
                Customers.Remove(customer);

                Console.WriteLine("");
                Console.WriteLine("Cliente eliminado con éxito!");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("El cliente no existe");
            }
        }
    }
}