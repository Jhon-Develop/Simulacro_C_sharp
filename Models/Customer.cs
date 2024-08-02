using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro_C_.Models
{
    public class Customer(string name, string lastName, string typeDocument, string identificationNumber, DateOnly birthDate, string email, string phoneNumber, string address, string membershipLevel, string preferredPaymentMethod) : User(name, lastName, typeDocument, identificationNumber, birthDate, email, phoneNumber, address)
    {
        public string MembershipLevel { get; set; } = membershipLevel;
        public string PreferredPaymentMethod { get; set; } = preferredPaymentMethod;

        public void UpdateMembershipLevel(string name, string lastName)
        {
            Customer? customer = Admin.Customers.Find(d => d.GetName() == name && d.GetLastName() == lastName);
            if (customer != null)   
            {
                string newMembershipLevel = Setting.InputString("Introduzca la nueva categoría de membresía o enter para mantener la misma => ");
                customer.MembershipLevel = string.IsNullOrEmpty(newMembershipLevel) ? customer.MembershipLevel : newMembershipLevel;

                Console.WriteLine("");
                Console.WriteLine("Membresía actualizada con éxito!");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("El cliente no existe");
            }
        }
    }
}