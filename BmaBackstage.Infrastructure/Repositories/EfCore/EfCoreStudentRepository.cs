using BmaBackstage.Domain.Entities;
using BmaBackstage.Domain.Entities.People;
using BmaBackstage.Domain.Entities.Progressions;
using BmaBackstage.Domain.Repositories;
using BmaBackstage.Infrastructure.DB;
using BmaBackstage.Infrastructure.DB.DataModel.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmaBackstage.Infrastructure.Repositories.EfCore
{
    public class EfCoreStudentRepository : IStudentRepository
    {
        private readonly BmaBackstageContext m_context;

        public EfCoreStudentRepository(BmaBackstageContext context)
        {
            m_context = context;
        }

        public void AddStudent(IStudent student)
        {
            m_context.Students.Add(
                new DB.DataModel.People.Student
                {
                    Name = student.Name,
                    BirthDay = student.BirthDay,
                    EmergencyContacts = new List<DB.DataModel.EmergencyContact>(),
                    Id = student.Id,
                });
            m_context.SaveChanges();
        }

        public void DeleteStudent(Guid studentId)
        {
            throw new NotImplementedException();
        }

        public IStudent GetStudentById(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IStudent> GetStudents()
        {
            //dbStudent.Progressions?.Select(
            //        dbProgression => new Progression(
            //            dbProgression.Name,
            //            dbProgression.Stages.Select(dbStage => new Domain.Entities.Progressions.ProgressionStage(
            //                dbStage.Name,
            //                new List<Domain.Entities.Progressions.Requirements.AbstractRequirement>() // dbStage.Requirements.Select(dbRequirement => new Requirement)
            //                )).ToList(),
            //            dbProgression.CurrentStageNumber)) ?? new List<Progression>();

            return m_context.Students.Select(
                dbStudent => new Domain.Entities.People.Student(
                    dbStudent.Name,
                    dbStudent.BirthDay,
                    new List<Progression>(),
                    new List<StudentContract>(),
                    new List<EmergencyContact>(),
                    new List<string>(), // dbStudent.SpecialNeeds.ToList(),
                    new List<string>())); // dbStudent.Notes?.ToList() ?? new List<string>()));
        }

        public IEnumerable<IStudent> GetStudentsByFuzzyName(string fuzzyName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IStudent> GetStudentsByName(string name)
        {
            throw new NotImplementedException();
        }

        public void UpdateStudent(IStudent student)
        {
            throw new NotImplementedException();
        }
    }
}
