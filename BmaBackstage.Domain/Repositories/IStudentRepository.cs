using BmaBackstage.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmaBackstage.Domain.Repositories
{
    public interface IStudentRepository
    {
        IEnumerable<IStudent> GetStudents();
        IEnumerable<IStudent> GetStudentsByName(string name);
        IEnumerable<IStudent> GetStudentsByFuzzyName(string fuzzyName);
        IStudent GetStudentById(Guid id);
    }
}
