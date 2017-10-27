using UnitOfWork;

namespace Repository
{
    public abstract class RepositoryBase : IRepositoryBase
    {
        public IDbFactory Factory { get; }
        protected RepositoryBase(IDbFactory factory)
        {
            Factory = factory;
        }
    }
}