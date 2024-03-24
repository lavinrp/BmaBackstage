namespace BmaBackstage.Domain.Entities.Progressions
{
    /// <summary>
    /// Any skill / rank that can be progressed through training
    /// </summary>
    public interface IProgression : IEntity
    {
        /// <summary>
        /// Human readable name of the progression
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Stages of the progression sorted so that the first stages appear at the start of the list
        /// </summary>
        /// <example>Stages[0]: WhiteBelt, Stages[1]: RedBelt, Stages[2]: OrangeBelt</example>
        List<ProgressionStage> Stages { get; }

        /// <summary>
        /// Index of current active stage
        /// </summary>
        int CurrentStageNumber { get; }

        /// <summary>
        /// Current active stage
        /// </summary>
        /// <returns>The current stage</returns>
        ProgressionStage GetCurrentStage();

        /// <summary>
        /// Progress through the progression. Range: [0.0, 1.0] 1.0 is 100%
        /// </summary>
        /// <returns>Progress through the progression</returns>
        double CalculateCompletionPercent();
    }
}
