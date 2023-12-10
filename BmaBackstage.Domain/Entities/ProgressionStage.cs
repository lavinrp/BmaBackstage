namespace BmaBackstage.Domain.Entities
{
    /// <summary>
    /// Stage of any training progression
    /// </summary>
    /// <example>Karate Belt progression would have a ProgressionStage instance for each belt.</example>
    /// <see cref="IProgression"/>
    public class ProgressionStage : IEntity
    {
        /// <summary>
        /// Construct a ProgressionStage with no requirements
        /// </summary>
        /// <param name="name">The name of the stage</param>
        public ProgressionStage(string name) : this(name, new List<AbstractRequirement>())
        {
        }

        /// <summary>
        /// Construct a ProgressionStage with the specified name and requirements.
        /// </summary>
        /// <param name="name">The name of the stage</param>
        /// <param name="requirements">The requirements for completion of the stage</param>
        public ProgressionStage(string name, List<AbstractRequirement> requirements)
        {
            Name = name;
            Requirements = requirements;
        }

        /// <summary>
        /// Human readable name of the stage
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Requirements that must be passed to complete the stage
        /// </summary>
        public List<AbstractRequirement> Requirements { get; private set; }

        /// <summary>
        /// Checks if all requirements have been passed
        /// </summary>
        /// <returns>True if all requirements have bene passed. False otherwise.</returns>
        public bool IsComplete()
        {
            return Requirements.All(x => x.HasPassed());
        }

        /// <summary>
        /// Unique identifier 
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();

    }
}
