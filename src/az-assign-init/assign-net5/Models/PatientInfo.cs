using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign_net5.Models
{
    public class PatientInfo
    {
        public int Id { get; init; }
        public string LastName { get; init; }
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
            IsWell = isWell;
        }
    }
}
