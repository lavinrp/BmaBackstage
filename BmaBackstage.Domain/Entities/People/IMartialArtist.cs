using BmaBackstage.Domain.Entities.Progressions;

namespace BmaBackstage.Domain.Entities.People
{
    /// <summary>
    /// Person training in any system
    /// </summary>
    public interface IMartialArtist : IPerson
    {
        /// <summary>
        /// Progressions that this person is training in.
        /// </summary>
        /// <example>Karate Belts, Instructor Certification, etc...</example>
        List<Progression> Progressions { get; }
    }
}
