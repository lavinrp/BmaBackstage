namespace BmaBackstage.Domain.Entities
{
    /// <summary>
    /// Tracks a requirement that must be manually approved.
    /// </summary>
    public class ManualApprovalRequirement : AbstractRequirement
    {
        /// <summary>
        /// Create a requirement that is only passed after manual approval
        /// </summary>
        /// <param name="name">Human readable name of the requirement</param>
        /// <param name="passed">Passed state of the requirement</param>
        public ManualApprovalRequirement(string name, bool passed = false)
        {
            Name = name;
            Passed = passed;
        }

        /// <summary>
        /// Passed state of the requirement
        /// </summary>
        public bool Passed { get; set; }

        /// <summary>
        /// Current progress towards completion of the requirement.
        /// </summary>
        /// <returns></returns>
        public override double CalculateCompletionPercent()
        {
            return Passed ? 1.0 : 0.0;
        }

        /// <summary>
        /// Checks if the requirement has been marked as passed
        /// </summary>
        /// <returns> True if the requirement has been passed. False otherwise. </returns>
        public override bool HasPassed()
        {
            return Passed;
        }
    }
}
