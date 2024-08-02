using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro_C_.Models
{
    public class Driver(string name, string lastName, string typeDocument, string identificationNumber, DateOnly birthDate, string email, string phoneNumber, string address, string licenseNumer, string licenseCategory, int drivingExperience) : User(name, lastName, typeDocument, identificationNumber, birthDate, email, phoneNumber, address)
    {

        public string LicenseNumber { get; set; } = licenseNumer;
        public string LicenseCategory { get; set; } = licenseCategory;
        public int DrivingExperience { get; set; } = drivingExperience;

        public void UpdateLicenseCategory(string name, string newCategory)
        {
            Driver? driver = Admin.Drivers.Find(l => l.LicenseCategory == newCategory);
            if (name == driver.GetName())
            {
                if (driver != null)
                {
                    string newLicenseCategory = Setting.InputString("Introduzca la nueva categoría de licencia o enter para mantener la misma => ");
                    driver.LicenseCategory = string.IsNullOrEmpty(newLicenseCategory) ? driver.LicenseCategory : newLicenseCategory;

                    Console.WriteLine("");
                    Console.WriteLine("Categoría de licencia actualizada con éxito!");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("LA licencia no existe");
                }
            }
            else
            {
                Console.WriteLine("El driver no existe");
            }
        }

        public void addExperience(string name, int years)
        {
            Driver? driver = Admin.Drivers.Find(l => l.DrivingExperience == years);
            if (name == driver.GetName())
            {
                if (driver != null)
                {
                    driver.DrivingExperience += years;

                    Console.WriteLine("");
                    Console.WriteLine("Experiencia actualizada con éxito!");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("LA licencia no existe");
                }
            }
            else
            {
                Console.WriteLine("El driver no existe");
            }
        }
    }
}