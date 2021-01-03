using System;
using System.Collections.Generic;
using System.Text;

namespace assign_netcore31.Models
{
    public class PatientInfo
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public bool IsWell { get; set; }

        public PatientInfo()
        {

        }

        public PatientInfo(int id, string lastName, string firstName, bool isWell)
        {
            Id = id;
            LastName = lastName;
            FirstName = firstName;
            IsWell = IsWell;
        }
    }
}
