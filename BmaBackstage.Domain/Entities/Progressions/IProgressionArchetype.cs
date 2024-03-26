namespace BmaBackstage.Domain.Entities.Progressions
{
    /// <summary>
    /// Template for a typical progression.
    /// Used to generate IProgression instances that individuals can progress through.
    /// IProgressionArchetype cannot be progressed since no single person works on the archetype.
    /// </summary>
    /// <see cref="IProgression"/>
    public interface IProgressionArchetype : IEntity
    {
        /// <summary>
        /// Human readable name of the archetype.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Typical stages of the typical progression
        /// </summary>
        IReadOnlyCollection<IProgressionStageArchetype> Stages { get; }

        /// <summary>
        /// Create a progression based on this archetype
        /// </summary>
        /// <returns>A progression based on this archetype</returns>
        IProgression CreateProgression();
    }
}
