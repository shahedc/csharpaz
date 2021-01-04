using assign_netcore31.Models;
using System;

namespace assign_netcore31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World from .NET Core 3.1!");

            // create a new patientInfo object
            var patientInfo = new PatientInfo
            {
                Id = 12345,
                LastName = "Doe",
                FirstName = "John",
                IsWell = true
            };

            Console.WriteLine($"ID={patientInfo.Id}");
            Console.WriteLine($"Full Name={patientInfo.FirstName} {patientInfo.LastName}");
            Console.WriteLine($"Sick? {!patientInfo.IsWell}");

            // try to change id: C# allows this before v9's init 
            patientInfo.Id = 99999;
            Console.WriteLine($"New Id={patientInfo.Id}");

            // try to change last name: C# allows this before v9's init 
            patientInfo.LastName = "Smith3000";
            Console.WriteLine($"New last name={patientInfo.LastName}");

            // create a new patientInfoWithId object
            var patientInfoWithId = new PatientInfoWithId(67890);
            patientInfoWithId.LastName = "Smith";
            patientInfoWithId.FirstName = "Joe";
            patientInfoWithId.IsWell = false;

            Console.WriteLine($"ID={patientInfoWithId.Id}");
            Console.WriteLine($"Full Name={patientInfoWithId.FirstName} {patientInfoWithId.LastName}");
            Console.WriteLine($"Sick? {!patientInfoWithId.IsWell}");

            // UNCOMMENT BELOW to change Id: doesn't work 
            //patientInfoWithId.Id = 99999;
            Console.WriteLine($"New Id={patientInfoWithId.Id}");
        }
    }
}
