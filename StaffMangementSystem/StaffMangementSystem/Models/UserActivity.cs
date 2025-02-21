using System.Runtime.InteropServices;

namespace StaffMangementSystem.Models
{
    public class UserActivity
    {
        public string? CreatedByID { get; set; }
        public DateTime CreatedOn { get; set; }

        public string? ModifiedByID { get; set; }
        public DateTime ModifiedOn { get; set; }

    }
}
