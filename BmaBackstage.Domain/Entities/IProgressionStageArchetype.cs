namespace BmaBackstage.Domain.Entities
{
    /// <summary>
    /// Template for a typical progression stage.
    /// Used to generate a ProgressionStage that individuals complete through an IProgression.
    /// IProgressionStageArchetype cannot be compleated since no single person works on the archetype.
    /// </summary>
    /// <see cref="IProgression"/>
    /// <see cref="ProgressionStage"/>
    public interface IProgressionStageArchetype
    {
        /// <summary>
        /// Human readable name of the archetype
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Requirements for the typical progression stage
        /// </summary>
        List<IRequirement> Requirements { get; set; }

        /// <summary>
        /// Create a ProgressionStage based on this archetype
        /// </summary>
        /// <returns>A ProgressionStage based on this archetype</returns>
        ProgressionStage CreateProgressionStage();
    }
}
