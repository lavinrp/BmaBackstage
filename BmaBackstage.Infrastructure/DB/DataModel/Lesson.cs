using BmaBackstage.Infrastructure.DB.DataModel.People;

namespace BmaBackstage.Infrastructure.DB.DataModel
{
    /// <summary>
    /// An individual training session
    /// </summary>
    internal class Lesson
    {
        /// <summary>
        /// The instructor leading the lesson
        /// </summary>
        public required Instructor Instructor { get; set; }

        /// <summary>
        /// The date of the lesson
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Unique identifier 
        /// </summary>
        public required Guid Id { get; set; }
    }
}
