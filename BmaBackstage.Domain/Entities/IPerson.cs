namespace BmaBackstage.Domain.Entities
{
    /// <summary>
    /// Any Person involved with the dojo
    /// </summary>
    public interface IPerson
    {
        /// <summary>
        /// Full name of the person
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Full date of birth
        /// </summary>
        DateTime BirthDay { get; }

        /// <summary>
        /// People who can be contacted in an emergency
        /// </summary>
        List<EmergencyContact> EmergencyContacts { get; }
    }
}
