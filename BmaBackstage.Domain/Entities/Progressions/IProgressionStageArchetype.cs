using BmaBackstage.Domain.Entities.Progressions.Requirements;
using System.Collections.ObjectModel;

namespace BmaBackstage.Domain.Entities.Progressions
{
    /// <summary>
    /// Template for a typical progression stage.
    /// Used to generate a ProgressionStage that individuals complete through an IProgression.
    /// IProgressionStageArchetype cannot be compleated since no single person works on the archetype.
    /// </summary>
    /// <see cref="IProgression"/>
    /// <see cref="ProgressionStage"/>
    public interface IProgressionStageArchetype : IEntity
    {
        /// <summary>
        /// Human readable name of the archetype
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Requirements for the typical progression stage
        /// </summary>
        IReadOnlyCollection<AbstractRequirement> Requirements { get; }

        /// <summary>
        /// Create a ProgressionStage based on this archetype
        /// </summary>
        /// <returns>A ProgressionStage based on this archetype</returns>
        ProgressionStage CreateProgressionStage();
    }
}
