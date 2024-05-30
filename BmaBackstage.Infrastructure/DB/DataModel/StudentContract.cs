namespace BmaBackstage.Infrastructure.DB.DataModel
{
    /// <summary>
    /// Contract for a student enrolled in any BMA class
    /// </summary>
    public class StudentContract
    {
        /// <summary>
        /// What the contract is for
        /// </summary>
        public required string ContractType { get; set; }

        /// <summary>
        /// The day that the contract takes effect
        /// </summary>
        public DateTime ContractStartDate { get; set; }

        /// <summary>
        /// The day that the contract ends
        /// </summary>
        public required DateTime ContractEndDate { get; set; }

        /// <summary>
        /// Unique identifier 
        /// </summary>
        public required Guid Id { get; set; }
    }
}
