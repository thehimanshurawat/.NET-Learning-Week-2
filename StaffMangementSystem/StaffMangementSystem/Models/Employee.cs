using System.ComponentModel.DataAnnotations;

namespace StaffMangementSystem.Models
{
    public class Employee : UserActivity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public double PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Department { get; set; }
        public string Designation { get; set; }
        public DateOnly DateofBirth { get; set; }
        public string Address { get; set; }
    }
}
