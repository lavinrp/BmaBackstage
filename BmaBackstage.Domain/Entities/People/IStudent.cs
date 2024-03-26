namespace BmaBackstage.Domain.Entities.People
{
    /// <summary>
    /// A student training at BMA
    /// </summary>
    public interface IStudent : IMartialArtist
    {
        /// <summary>
        /// All contracts on file for student
        /// </summary>
        IReadOnlyCollection<StudentContract> Contracts { get;}

        /// <summary>
        /// Special needs that should be understood by instructors
        /// </summary>
        IReadOnlyCollection<string> SpecialNeeds { get; }

        /// <summary>
        /// Misc notes that should be understood by instructors
        /// </summary>
        IReadOnlyCollection<string> Notes { get; }
    }
}
