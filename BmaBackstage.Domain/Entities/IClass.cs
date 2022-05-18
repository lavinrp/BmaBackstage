namespace BmaBackstage.Domain.Entities
{
    /// <summary>
    /// Represents a scheduled set of lessons.
    /// </summary>
    /// <example>Tuesday/Thursday Advanced Class, Monday/Wednesday Novice Class, Self Defense Class</example>
    public interface IClass
    {
        /// <summary>
        /// Instructors regularly leading the class
        /// </summary>
        List<IInstructor> HeadInstructors { get; set; }

        /// <summary>
        /// Instructors regularly assisting with the class
        /// </summary>
        List<IInstructor> AssistantInstructors { get; set; }

        /// <summary>
        /// Students regularly taking the class
        /// </summary>
        List<IStudent> Students { get; set; }

        /// <summary>
        /// The days that the class takes place each week
        /// </summary>
        List<DayOfWeek> DaysOfWeek { get; set; }

        /// <summary>
        /// The time of day that the class takes place
        /// </summary>
        TimeSpan TimeOfDay { get; set; }

        /// <summary>
        /// The progressions that the students of this class are working towards.
        /// </summary>
        /// <example>Karate Belts, Kobudo Belts, Instructor Certification</example>
        List<IProgressionArchetype> ProgressionArchetypes { get; set; }

        /// <summary>
        /// Human readable name for the class
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// The dojo in which the class normally takes place
        /// </summary>
        IDojo Dojo { get; set; }

        /// <summary>
        /// The individual lessons that have been held by this class
        /// </summary>
        List<Lesson> Lessons { get; set; }
    }
}
