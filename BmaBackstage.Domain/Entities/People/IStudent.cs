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
        List<StudentContract> Contracts { get; set; }

        /// <summary>
        /// Special needs that should be understood by instructors
        /// </summary>
        List<string> SpecialNeeds { get; set; }

        /// <summary>
        /// Misc notes that should be understood by instructors
        /// </summary>
        List<string> Notes { get; set; }
    }
}
