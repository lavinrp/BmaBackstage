
namespace BmaBackstage.Domain.Entities
{
    /// <summary>
    /// Represents a requirement of a ProgressionStage
    /// </summary>
    public abstract class AbstractRequirement : IEntity
    {
        /// <summary>
        /// Human readable name for the requirement
        /// </summary>
        public string Name { get; set; } = string.Empty;

        public Guid Id { get; set; }

        /// <summary>
        /// Checks if the requirement has been met
        /// </summary>
        /// <returns>True if the requirement has been met. False otherwise.</returns>
        public abstract bool HasPassed();

        /// <summary>
        /// Current progress towards completion of the requirement.
        /// </summary>
        /// <returns>Percent of requirement completed. 1.0 is 100%</returns>
        public abstract double CalculateCompletionPercent();
    }
}
