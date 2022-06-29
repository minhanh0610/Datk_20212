using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Datk.EntityFramework.Repositories
{
    public abstract class DatkRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<DatkDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected DatkRepositoryBase(IDbContextProvider<DatkDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class DatkRepositoryBase<TEntity> : DatkRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected DatkRepositoryBase(IDbContextProvider<DatkDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
