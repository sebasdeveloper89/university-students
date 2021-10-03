using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Students.Domain
{
    public class Team
    {
        public int IdTeam { get; set; }

        public string IdentificationNumber { get; set; }

        public string IdentificationType {get;set;}

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public string ShowFullName()
        {
            return $"{FirstName} {LastName}";
        }

    }
}
