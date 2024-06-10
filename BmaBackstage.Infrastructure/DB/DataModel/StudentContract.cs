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

        /// <summary>
        /// Convert a StudentContract entity into a persistence object.
        /// </summary>
        /// <param name="studentContract"></param>
        /// <returns></returns>
        public static StudentContract FromEntity(Domain.Entities.StudentContract studentContract)
        {
            return new StudentContract
            {
                ContractType = studentContract.ContractType,
                ContractStartDate = studentContract.ContractStartDate,
                ContractEndDate = studentContract.ContractEndDate,
                Id = studentContract.Id
            };
        }

        /// <summary>
        /// Convert this StudentContract persistence object into an entity.
        /// </summary>
        /// <returns></returns>
        public Domain.Entities.StudentContract ToEntity() 
        {
            return new Domain.Entities.StudentContract
            {
                ContractType = ContractType,
                ContractStartDate = ContractStartDate,
                ContractEndDate = ContractEndDate,
                Id = Id,
            };
        }
    }
}
