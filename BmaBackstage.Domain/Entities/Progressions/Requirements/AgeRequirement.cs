using BmaBackstage.Domain.Entities.People;

namespace BmaBackstage.Domain.Entities.Progressions.Requirements
{
    /// <summary>
    /// Tracks minimum age required to complete a ProgressionStage
    /// </summary>
    public class AgeRequirement : AbstractRequirement
    {
        /// <summary>
        /// Create an age requirement that will be passed when
        /// the specified person is older than the required age.
        /// </summary>
        /// <param name="name">Huan readable name for the requirement.</param>
        /// <param name="requiredAge">Minimum age required to pass the requirement.</param>
        /// <param name="person">Person who must be the requiredAge</param>
        public AgeRequirement(string name, int requiredAge, Student person)
        {
            m_person = person;
            Name = name;
            RequiredAge = requiredAge;
        }

        private readonly Student m_person;

        /// <summary>
        /// Minimum age required to pass the requirement.
        /// </summary>
        public int RequiredAge { get; private set; }

        /// <summary>
        /// Current progress towards completion of the requirement.
        /// </summary>
        /// <returns>ratio of current age to required age. 1.0 is 100% </returns>
        public override double CalculateCompletionPercent()
        {
            if (HasPassed())
            {
                return 1.0;
            }
            return (double)GetCurrentAge() / RequiredAge;
        }

        /// <summary>
        /// Checks if the age requirement has been met.
        /// </summary>
        /// <returns>Returns true if the specified person is at least the required age. False otherwise.</returns>
        public override bool HasPassed()
        {
            return GetCurrentAge() >= RequiredAge;
        }

        /// <summary>
        /// Calculate the current age of the specified person
        /// </summary>
        /// <returns> Age in years </returns>
        private int GetCurrentAge()
        {
            // https://stackoverflow.com/questions/9/how-do-i-calculate-someones-age-based-on-a-datetime-type-birthday

            // Save today's date.
            var today = DateTime.Today;
            var birthday = m_person.BirthDay.Date;

            // Calculate the age.
            var age = today.Year - birthday.Year;

            // Go back to the year in which the person was born in case of a leap year
            if (birthday.Date > today.AddYears(-age))
            {
                age--;
            }
            return age;
        }
    }
}
