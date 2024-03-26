using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BmaBackstage.Domain.Entities.Progressions;

namespace BmaBackstage.Domain.Entities.People
{
    public class Student : IStudent
    {
        public Student(
            string name,
            DateTime birthDay,
            List<Progression> progressions,
            List<StudentContract> contracts,
            List<EmergencyContact> emergencyContacts,
            List<string> specialNeeds,
            List<string> notes)
        {
            m_contracts= contracts;
            m_specialNeeds = specialNeeds;
            m_notes = notes;
            m_progressions = progressions;
            Name = name;
            BirthDay = birthDay;
            m_emergencyContacts = emergencyContacts;
        }

        private readonly List<StudentContract> m_contracts = new();
        private readonly List<string> m_specialNeeds = new();
        private readonly List<string> m_notes = new();
        private readonly List<Progression> m_progressions = new();
        private readonly List<EmergencyContact> m_emergencyContacts= new();

        public IReadOnlyCollection<StudentContract> Contracts => m_contracts;
        public IReadOnlyCollection<string> SpecialNeeds => m_specialNeeds;
        public IReadOnlyCollection<string> Notes => m_notes;
        public IReadOnlyCollection<IProgression> Progressions => m_progressions;
        public string Name { get; set; } = string.Empty;
        public DateTime BirthDay { get; set; } = DateTime.MinValue;
        public IReadOnlyCollection<EmergencyContact> EmergencyContacts => m_emergencyContacts;

        /// <summary>
        /// Unique identifier 
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}
