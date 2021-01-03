using assign_net5.Models;
using System;

Console.WriteLine("Hello World from .NET 5!");

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

// UNCOMMENT BELOW to change Id: doesn't work with C#9 in .NET 5
//patientInfo.Id = 99999;
Console.WriteLine($"New Id={patientInfo.Id}");

// UNCOMMENT BELOW to change last name: doesn't work with C#9 in .NET 5
// patientInfo.LastName = "Smith3000";
Console.WriteLine($"New last name={patientInfo.LastName}");


