using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro_C_.Models
{
    public class Vehicle(int id, string placa, string type, string engineNumber, string serialNumber, byte peopleCapacity, Driver owner)
    {
        public int Id { get; set; } = id;
        public string Placa { get; set; } = placa;
        public string Type { get; set; } = type;
        public string EngineNumber { get; set; } = engineNumber;
        public string SerialNumber { get; set; } = serialNumber;
        public byte PeopleCapacity { get; set; } = peopleCapacity;
        public Driver Owner { get; set; } = owner;

    }
}