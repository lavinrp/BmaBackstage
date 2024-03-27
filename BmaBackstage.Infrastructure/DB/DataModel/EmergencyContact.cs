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
    }
}
