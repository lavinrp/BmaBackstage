using BmaBackstage.Domain.Entities.Progressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmaBackstage.Domain.Entities.People
{
    public class Instructor : IInstructor
    {
        private readonly List<TimeSheetEntry> m_timeSheet = new();
        private readonly List<Progression> m_progressions = new();
        private readonly List<EmergencyContact> m_emergencyContacts = new();

        public Instructor(
            string name,
            DateTime birthday,
            DateTime lastSafeSportTestDate,
            DateTime lastBackgroundCheckDate,
            List<TimeSheetEntry> timeSheet, 
            List<Progression> progressions, 
            List<EmergencyContact> emergencyContacts) 
        {
            Name = name;
            BirthDay = birthday;
            LastSafeSportTestDate = lastBackgroundCheckDate;
            LastBackgroundCheckDate = lastBackgroundCheckDate;
            m_timeSheet = timeSheet;
            m_progressions = progressions;
            m_emergencyContacts = emergencyContacts;
        }

        public DateTime LastSafeSportTestDate { get; set; } = DateTime.MinValue;

        public DateTime LastBackgroundCheckDate { get; set; } = DateTime.MinValue;

        public IReadOnlyCollection<TimeSheetEntry> TimeSheet => m_timeSheet;

        public IReadOnlyCollection<IProgression> Progressions => m_progressions;

        public string Name { get; set; } = string.Empty;

        public DateTime BirthDay { get; set; } = DateTime.MinValue;

        public IReadOnlyCollection<EmergencyContact> EmergencyContacts => m_emergencyContacts;

        public Guid Id { get; set; } = Guid.NewGuid();
    }
}
