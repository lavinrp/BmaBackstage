namespace BmaBackstage.Domain.Entities
{
    /// <summary>
    /// An individual training session
    /// </summary>
    public class Lesson
    {
        /// <summary>
        /// Construct a lesson tought by the specified instructor at the specified time
        /// </summary>
        /// <param name="instructor">The instructor leading the lesson</param>
        /// <param name="date">The date of the lesson</param>
        public Lesson(IInstructor instructor, DateTime date)
        {
            Instructor = instructor;
            Date = date;
        }

        /// <summary>
        /// The instructor leading the lesson
        /// </summary>
        public IInstructor Instructor { get; private set; }

        /// <summary>
        /// The date of the lesson
        /// </summary>
        public DateTime Date { get; private set; }
    }
}
