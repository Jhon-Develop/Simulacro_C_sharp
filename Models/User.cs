using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro_C_.Models
{
    public class User(string name, string lastName, string typeDocument, string identificationNumber, DateOnly birthDate, string email, string phoneNumber, string address)
    {
        protected string  Name { get; set; } = name;
        protected string  LastName { get; set; } = lastName;
        protected string TypeDocument { get; set; } = typeDocument;
        protected string IdentificationNumber { get; set; } = identificationNumber;
        protected DateOnly BirthDate { get; set; } = birthDate;
        protected string Email { get; set; } = email;
        protected string PhoneNumber { get; set; } = phoneNumber;
        protected string Address { get; set; } = address;

        // get Property
        public string GetName() => Name;
        public string GetLastName() => LastName;
        public string GetTypeDocument() => TypeDocument;
        public string GetIdentificationNumber() => IdentificationNumber;
        public DateOnly GetBirthDate() => BirthDate;
        public string GetEmail() => Email;
        public string GetPhoneNumber() => PhoneNumber;
        public string GetAddress() => Address;
        
        // set Property
        public string SetName(string name) => Name = name;
        public string SetLastName(string lastName) => LastName = lastName;
        public string SetTypeDocument(string typeDocument) => TypeDocument = typeDocument;
        public string SetIdentificationNumber(string identificationNumber) => IdentificationNumber = identificationNumber;
        public DateOnly SetBirthDate(DateOnly birthDate) => BirthDate = birthDate;
        public string SetEmail(string email) => Email = email;
        public string SetPhoneNumber(string phoneNumber) => PhoneNumber = phoneNumber;
        public string SetAddress(string address) => Address = address;

        protected void ShowDetails()
        {
            Console.WriteLine(@$"
            Nombre: {Name}
            Apellido: {LastName}
            Tipo de documento: {TypeDocument}
            Numero de identificacion: {IdentificationNumber}
            Fecha de nacimiento: {BirthDate}
            Email: {Email}
            Telefono: {PhoneNumber}
            Direccion: {Address}
            ");
        }

        protected int CalculateAge()
        {
            DateOnly today = DateOnly.FromDateTime(DateTime.Now);
            int age = today.Year - birthDate.Year;
            if (today.Month < birthDate.Month || (today.Month == birthDate.Month && today.Day < birthDate.Day))
            {
                age--;
            }
            return age;
        }

        protected void ShowAge()
        {
            Console.WriteLine(@$"
            Tu edad es {CalculateAge()}");
        }
    }
}