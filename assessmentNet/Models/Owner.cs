using System;
using System.Collections.Generic;

namespace assessmentNet.Models
{
    public partial class Owner
    {
        public Owner()
        {
            Vehicles = new HashSet<Vehicle>();
        }

        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? DriverLicense { get; set; }

        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
