namespace BmaBackstage.Infrastructure.DB.DataModel
{
    /// <summary>
    /// Emergency contact information
    /// </summary>
    public class EmergencyContact
    {
        /// <summary>
        /// Full name of emergency contact
        /// </summary>
        public required string Name { get; set; }

        /// <summary>
        /// Phone number of emergency contact
        /// </summary>
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Email address of emergency contact
        /// </summary>
        public string? Email { get; set; }

        /// <summary>
        /// Relationship of emergency contact to person.
        /// Example: Parent, Sister, etc...
        /// </summary>
        public string? Relationship { get; set; }

        /// <summary>
        /// Misc info about emergency contact
        /// </summary>
        public List<string>? Notes { get; set; }

        /// <summary>
        /// Unique identifier 
        /// </summary>
        public required Guid Id { get; set; }

        /// <summary>
        /// Create a persistence object from a EmergencyContact entity.
        /// </summary>
        /// <param name="emergencyContact"></param>
        /// <returns></returns>
        public static EmergencyContact FromEntity(Domain.Entities.EmergencyContact emergencyContact)
        {
            return new EmergencyContact
            {
                Name = emergencyContact.Name,
                PhoneNumber = emergencyContact.PhoneNumber,
                Email = emergencyContact.Email,
                Relationship = emergencyContact.Relationship,
                Notes = emergencyContact.Notes,
                Id = emergencyContact.Id,
            };
        }

        /// <summary>
        /// Create an EmergencyContact entity from a persistence object.
        /// </summary>
        /// <returns></returns>
        public Domain.Entities.EmergencyContact ToEntity()
        {
            return new Domain.Entities.EmergencyContact
            {
                Name = Name,
                PhoneNumber = PhoneNumber ?? string.Empty,
                Email = Email ?? string.Empty,
                Relationship = Relationship ?? string.Empty,
                Notes = Notes ?? new List<string>(),
                Id = Id
            };
        }
    }
}
