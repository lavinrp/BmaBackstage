namespace BmaBackstage.Domain.Entities
{
    /// <summary>
    /// Instructor of any BMA class.
    /// </summary>
    public interface IInstructor : IEmployee, IMartialArtist
    {
        /// <summary>
        /// Time of last passed safe sport test
        /// </summary>
        DateTime LastSafeSportTestDate { get; set; }

        /// <summary>
        /// Time of last passed background check
        /// </summary>
        DateTime LastBackgroundCheckDate { get; set; }
    }
}
