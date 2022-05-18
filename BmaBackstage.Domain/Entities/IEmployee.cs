namespace BmaBackstage.Domain.Entities
{
    /// <summary>
    /// BMA employee
    /// </summary>
    public interface IEmployee
    {
        /// <summary>
        /// Record of recent hours worked
        /// </summary>
        List<TimeSheetEntry> TimeSheet { get; }
    }
}
