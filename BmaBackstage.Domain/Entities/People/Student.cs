﻿using System;
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
            Contracts = contracts;
            SpecialNeeds = specialNeeds;
            Notes = notes;
            Progressions = progressions;
            Name = name;
            BirthDay = birthDay;
            EmergencyContacts = emergencyContacts;
        }

        public List<StudentContract> Contracts { get; set; }
        public List<string> SpecialNeeds { get; set; }
        public List<string> Notes { get; set; }

        public List<Progression> Progressions { get; set; }

        public string Name { get; set; }

        public DateTime BirthDay { get; set; }

        public List<EmergencyContact> EmergencyContacts { get; set; }

        /// <summary>
        /// Unique identifier 
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}