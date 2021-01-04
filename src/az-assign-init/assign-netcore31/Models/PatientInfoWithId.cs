namespace assign_netcore31.Models
{
    public class PatientInfoWithId
    {
        public int Id { get; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public bool IsWell { get; set; }

        public PatientInfoWithId(int id)
        {
            Id = id;
        }

        public PatientInfoWithId(int id, string lastName, string firstName, bool isWell)
        {
            Id = id;
            LastName = lastName;
            FirstName = firstName;
            IsWell = isWell;
        }
    }
}
