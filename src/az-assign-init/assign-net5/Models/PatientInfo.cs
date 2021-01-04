namespace assign_net5.Models
{
    public class PatientInfo
    {
        public int Id { get; init; }
        public string LastName { get; init; }
        public string FirstName { get; set; }
        public bool IsWell { get; set; }

    }
}
