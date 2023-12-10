using BmaBackstage.Domain.Entities;
using BmaBackstage.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BmaBackstage.Infrastructure.Repositories
{
    public class InMemoryStudentRepository : IStudentRepository
    {
        public InMemoryStudentRepository()
        {
            m_students = new List<IStudent>
            {
                MakeRandomStudent(),
                MakeRandomStudent(),
                MakeRandomStudent(),
                MakeRandomStudent(),
            };
        }

        public IEnumerable<IStudent> GetStudents()
        {
            return m_students;
        }

        public IEnumerable<IStudent> GetStudentsByFuzzyName(string fuzzyName)
        {
            var levenshteinDistance = (string s, string t) =>
            {
                if (string.IsNullOrEmpty(s))
                {
                    if (string.IsNullOrEmpty(t))
                        return 0;
                    return t.Length;
                }

                if (string.IsNullOrEmpty(t))
                {
                    return s.Length;
                }

                int n = s.Length;
                int m = t.Length;
                int[,] d = new int[n + 1, m + 1];

                // initialize the top and right of the table to 0, 1, 2, ...
                for (int i = 0; i <= n; d[i, 0] = i++) ;
                for (int j = 1; j <= m; d[0, j] = j++) ;

                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= m; j++)
                    {
                        int cost = (t[j - 1] == s[i - 1]) ? 0 : 1;
                        int min1 = d[i - 1, j] + 1;
                        int min2 = d[i, j - 1] + 1;
                        int min3 = d[i - 1, j - 1] + cost;
                        d[i, j] = Math.Min(Math.Min(min1, min2), min3);
                    }
                }
                return d[n, m];
            };

            const int maxLevenshteinDistance = 5;
            return m_students.Where(student => levenshteinDistance(fuzzyName, student.Name) <= maxLevenshteinDistance);
        }

        public IEnumerable<IStudent> GetStudentsByName(string name)
        {
            return m_students.Where(student => student.Name == name);
        }
        
        public IStudent GetStudentById(Guid id)
        {
            return m_students.First(student => student.Id == id);
        }

        public void UpdateStudent(IStudent student)
        {
            int oldStudentIndex = m_students.FindIndex(oldStudent => oldStudent.Id == student.Id);
            if (oldStudentIndex != -1)
            {
                m_students[oldStudentIndex] = student;
            }
        }

        public void AddStudent(IStudent student)
        {
            m_students.Add(student);
        }

        public void DeleteStudent(Guid studentId)
        {
            m_students.RemoveAll(student => student.Id == studentId);
        }

        private string MakeRandomFirstName()
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

        private string MakeRandomLastName()
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

        private DateTime MakeRandomDate(DateTime minDate, DateTime maxDate)
        {
            List<DateTime> myDates = new List<DateTime>();
            int minutesDiff = Convert.ToInt32(maxDate.Subtract(minDate).TotalMinutes + 1);
            // some random number that's no larger than minutesDiff, no smaller than 1
            int r = m_random.Next(1, minutesDiff);
            return minDate.AddMinutes(r);
        }

        private Student MakeRandomStudent()
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
                        PhoneNumber = "867-5309",
                        Email="test@fake.net",
                        Notes = "Only available when the sun is not out due to vampirism."
                    }
                    },
                specialNeeds: new List<string>(),
                notes: new List<string>() { "" }


            );
        }


        public List<IStudent> m_students = new();
        private Random m_random = new();
    }
}
