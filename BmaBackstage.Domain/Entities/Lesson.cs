using BmaBackstage.Domain.Entities.People;

namespace BmaBackstage.Domain.Entities
{
    /// <summary>
    /// An individual training session
    /// </summary>
    public class Lesson : IEntity
    {
        /// <summary>
        /// Construct a lesson tought by the specified instructor at the specified time
        /// </summary>
        /// <param name="instructor">The instructor leading the lesson</param>
        /// <param name="date">The date of the lesson</param>
        //public Lesson(Instructor instructor, DateTime date)
        //{
        //    Instructor = instructor;
        //    Date = date;
        //}

        /// <summary>
        /// The instructor leading the lesson
        /// </summary>
        public Instructor Instructor { get; set; }

        /// <summary>
        /// The date of the lesson
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Unique identifier 
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}
