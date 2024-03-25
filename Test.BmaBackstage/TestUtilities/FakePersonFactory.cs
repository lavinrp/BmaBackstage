
using BmaBackstage.Domain.Entities;
using BmaBackstage.Domain.Entities.People;
using BmaBackstage.Domain.Entities.Progressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.BmaBackstage.TestUtilities
{
    internal static class FakePersonFactory
    {
        private static Random m_random = new();

        private static string MakeRandomFirstName()
        {
            var names = new List<string>()
        {
            "James",
            "John",
            "Robert",
            "Michael",
            "William",
            "David",
            "Richard",
            "Mary",
            "Patricia",
            "Linda",
            "Barbara",
            "Elizabeth",
            "Jennifer",
            "Maria",
            "Susan",
        };
            return names[m_random.Next(names.Count)];
        }

        private static string MakeRandomLastName()
        {
            var names = new List<string>()
        {
            "Johnson",
            "Jones",
            "Garcia",
            "Rodriguez",
            "Martinez",
            "Thomas",
            "Moore",
            "Lopez",
            "Williams",
            "Smith",
            "Anderson",
            "Taylor",
            "Thompson",
            "Hernandez",
            "White",
            "Brown",
            "Brown",
            "Miller",
            "Wilson",
            "Jackson",
            "Martin",
            "Gonzalez",

        };
            return names[m_random.Next(names.Count)];
        }

        private static DateTime MakeRandomDate(DateTime minDate, DateTime maxDate)
        {
            List<DateTime> myDates = new List<DateTime>();
            int minutesDiff = Convert.ToInt32(maxDate.Subtract(minDate).TotalMinutes + 1);
            // some random number that's no larger than minutesDiff, no smaller than 1
            int r = m_random.Next(1, minutesDiff);
            return minDate.AddMinutes(r);
        }

        private static string MakeRandomPhoneNumber()
        {
            StringBuilder phoneNumberBuilder = new();
            for (int i = 0; i < 3; ++i)
            {
                phoneNumberBuilder.Append(m_random.Next());
            }
            phoneNumberBuilder.Append("-");
            for (int i = 0; i < 3; ++i)
            {
                phoneNumberBuilder.Append(m_random.Next());
            }
            phoneNumberBuilder.Append("-");
            for (int i = 0; i < 4; ++i)
            {
                phoneNumberBuilder.Append(m_random.Next());
            }
            return phoneNumberBuilder.ToString();
        }

        public static Student MakeRandomStudent()
        {
            return new Student(
                name: MakeRandomFirstName() + " " + MakeRandomLastName(),
                birthDay: MakeRandomDate(
                    minDate: new DateTime(1980, 1, 1, 10, 0, 0),
                    maxDate: new DateTime(2020, 1, 1, 10, 0, 0)),
                progressions: new List<Progression>
                {
                new Progression(
                    "Karate",
                    new List<ProgressionStage>
                    {
                        new ProgressionStage(name: "9th Kyu"),
                        new ProgressionStage(name: "8th Kyu"),
                        new ProgressionStage(name: "7th Kyu"),
                        new ProgressionStage(name: "6th Kyu"),
                        new ProgressionStage(name: "5th Kyu"),
                        new ProgressionStage(name: "4th Kyu"),
                        new ProgressionStage(name: "3rd Kyu"),
                        new ProgressionStage(name: "2nd Kyu"),
                        new ProgressionStage(name: "1st Kyu"),
                        new ProgressionStage(name: "1st Dan"),
                        new ProgressionStage(name: "2nd Dan"),
                        new ProgressionStage(name: "3rd Dan"),
                        new ProgressionStage(name: "4th Dan"),
                        new ProgressionStage(name: "5th Dan"),
                        new ProgressionStage(name: "6th Dan"),
                        new ProgressionStage(name: "7th Dan"),
                        new ProgressionStage(name: "8th Dan"),
                        new ProgressionStage(name: "9th Dan"),
                        new ProgressionStage(name: "10th Dan"),
                    },
                    currentStageNumber: m_random.Next(13))
                },
                contracts: new List<StudentContract>
                {
                new StudentContract()
                {
                    ContractType = "Karate",
                    ContractStartDate =
                        MakeRandomDate(
                        minDate:new DateTime(2020, 1, 1, 10, 0, 0),
                        maxDate: new DateTime(2023, 1, 1, 10, 0, 0)),
                    ContractEndDate =
                    MakeRandomDate(
                        minDate:new DateTime(2023, 2, 1, 10, 0, 0),
                        maxDate: new DateTime(2026, 1, 1, 10, 0, 0)),

                }
                },
                emergencyContacts:
                    new List<EmergencyContact>()
                    {
                    new EmergencyContact
                    {
                        Name = MakeRandomFirstName() + " " + MakeRandomLastName(),
                        Relationship = "Parent",
                        PhoneNumber = MakeRandomPhoneNumber(),
                        Email="test@fake.net",
                        Notes = "Only available when the sun is not out due to vampirism."
                    }
                    },
                specialNeeds: new List<string>(),
                notes: new List<string>() { "" }


            );
        }
    }
}
