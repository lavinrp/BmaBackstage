namespace BmaBackstage.Domain.Entities
{
    /// <summary>
    /// Represents a requirement of a ProgressionStage
    /// </summary>
    public interface IRequirement
    {
        /// <summary>
        /// Human readable name for the requirement
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Checks if the requirement has been met
        /// </summary>
        /// <returns>True if the requirement has been met. False otherwise.</returns>
        bool HasPassed();

        /// <summary>
        /// Current progress towards completion of the requirement.
        /// </summary>
        /// <returns>Percent of requirement completed. 1.0 is 100%</returns>
        double CalculateCompletionPercent();
    }
}
