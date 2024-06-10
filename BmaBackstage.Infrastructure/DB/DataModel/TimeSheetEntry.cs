namespace BmaBackstage.Infrastructure.DB.DataModel
{
    /// <summary>
    /// Records time worked in a single day
    /// </summary>
    public class TimeSheetEntry
    {
        /// <summary>
        /// Day that the work took place
        /// </summary>
        public required DateTime Day { get; set; }

        /// <summary>
        /// Duration of the work
        /// </summary>
        public required TimeSpan Duration { get; set; }

        /// <summary>
        /// Unique identifier 
        /// </summary>
        public required Guid Id { get; set; }

        /// <summary>
        /// Create a TimeSheetEntry entity from this persistence object
        /// </summary>
        /// <returns></returns>
        public Domain.Entities.TimeSheetEntry ToEntity()
        {
            return new Domain.Entities.TimeSheetEntry
            {
                Day = Day,
                Duration = Duration,
                Id = Id
            };
        }

        /// <summary>
        /// Create a TimeSheetEntry persistence object from a TimeSheetEntry entity.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static TimeSheetEntry FromEntity(Domain.Entities.TimeSheetEntry entity)
        {
            return new TimeSheetEntry
            {
                Day = entity.Day,
                Duration = entity.Duration,
                Id = entity.Id
            };
        }
    }
}
