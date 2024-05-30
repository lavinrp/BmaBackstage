using BmaBackstage.Domain.Repositories;
using BmaBackstage.Infrastructure.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmaBackstage.Infrastructure.Repositories.EfCore
{
    public class EfCoreRepositoryFactory : IRepositoryFactory
    {
        private readonly BmaBackstageContext m_context;

        public EfCoreRepositoryFactory(BmaBackstageContext context)
        {
            m_context = context;
        }

        public IStudentRepository CreateStudentRepository()
        {
            return new EfCoreStudentRepository(m_context);
        }
    }
}
