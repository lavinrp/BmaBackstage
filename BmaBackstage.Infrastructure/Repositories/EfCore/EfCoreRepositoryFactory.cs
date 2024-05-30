using BmaBackstage.Domain.Repositories;
using BmaBackstage.Infrastructure.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BmaBackstage.Infrastructure.Repositories.EfCore
{
    public class EfCoreRepositoryFactory : IRepositoryFactory
    {
        // private readonly BmaBackstageContext m_context;

        private readonly IDbContextFactory<BmaBackstageContext> m_contextFactory;

        public EfCoreRepositoryFactory(IDbContextFactory<BmaBackstageContext> contextFactory)
        {
            m_contextFactory = contextFactory;
        }

        public IStudentRepository CreateStudentRepository()
        {
            return new EfCoreStudentRepository(m_contextFactory.CreateDbContext());
        }
    }
}
