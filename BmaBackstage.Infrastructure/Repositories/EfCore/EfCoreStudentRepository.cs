using BmaBackstage.Domain.Entities.People;
using BmaBackstage.Domain.Repositories;
using BmaBackstage.Infrastructure.DB;
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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
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
