using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmaBackstage.Domain.Entities
{
    /// <summary>
    /// Emergency contact information
    /// </summary>
    public class EmergencyContact
    {
        /// <summary>
        /// Full name of emergency contact
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Phone numer of emergency contact
        /// </summary>
        public string PhoneNumber { get; set; } = string.Empty;

        /// <summary>
        /// Email address of emergency contact
        /// </summary>
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// Relationship of emergency contact to person.
        /// Example: Parent, Sister, etc...
        /// </summary>
        public string Relationship { get; set; } = string.Empty;

        /// <summary>
        /// Misc info about emergency contact
        /// </summary>
        public string Notes { get; set; } = string.Empty;
    }
}
