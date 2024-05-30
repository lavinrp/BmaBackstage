using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmaBackstage.Infrastructure.DB.DataModel.People
{
    public class Person
    {
        /// <summary>
        /// Full name of the person
        /// </summary>
        public required string Name { get; set;  }

        /// <summary>
        /// Full date of birth
        /// </summary>
        public required DateTime BirthDay { get; set; }

        /// <summary>
        /// People who can be contacted in an emergency
        /// </summary>
        public required List<EmergencyContact> EmergencyContacts { get; set; }

        public required Guid Id { get; set; }
    }
}
