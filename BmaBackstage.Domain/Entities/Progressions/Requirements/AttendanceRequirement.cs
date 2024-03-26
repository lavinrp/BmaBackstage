namespace BmaBackstage.Domain.Entities.Progressions.Requirements
{
    /// <summary>
    /// Tracks minimum attendance required to complete a ProgressionStage
    /// </summary>
    public class AttendanceRequirement : AbstractRequirement
    {
        private readonly List<Lesson> m_lessions;

        /// <summary>
        /// Create an attendance requirement that will be passed when 
        /// the specified lessons count >= the required lesson count.
        /// </summary>
        /// <param name="name">Human readable name for the requirement.</param>
        /// <param name="requiredLessonCount">Number of lessons required to pass the requirement</param>
        /// <param name="lessons">Current lessons taken towards the requirement.</param>
        public AttendanceRequirement(string name, int requiredLessonCount, List<Lesson> lessons)
        {
            Name = name;
            RequiredLessonCount = requiredLessonCount;
            m_lessions = lessons;
        }

        /// <summary>
        /// The number of lessons required to pass the requirement
        /// </summary>
        public int RequiredLessonCount { get; init; }

        /// <summary>
        /// The current lessons taken towards the requirement
        /// </summary>
        public IReadOnlyCollection<Lesson> Lessons => m_lessions;

        /// <summary>
        /// Checks if the attendance requirement has been met.
        /// </summary>
        /// <returns>Returns true if the number of lessons is greater than the required lesson count. False otherwise. </returns>
        public override bool HasPassed()
        {
            return Lessons.Count >= RequiredLessonCount;
        }

        /// <summary>
        /// Current progress towards completion of the requirement.
        /// </summary>
        /// <returns> Ratio of required classes to current classes. 1.0 is 100% </returns>
        public override double CalculateCompletionPercent()
        {
            if (HasPassed())
            {
                return 1.0;
            }
            return (double)Lessons.Count / RequiredLessonCount;
        }
    }
}
