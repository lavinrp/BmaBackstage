namespace BmaBackstage.Domain.Entities
{
    /// <summary>
    /// Contract for a student entrolled in any BMA class
    /// </summary>
    public class StudentContract
    {
        /// <summary>
        /// The day that the contract takes effect
        /// </summary>
        public DateTime ContractStartDate { get; set; }

        /// <summary>
        /// The day that the contract ends
        /// </summary>
        public DateTime ContractEndDate { get; set; }
    }
}
