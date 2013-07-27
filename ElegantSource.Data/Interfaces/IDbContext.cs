using System.Data.Entity;

namespace ElegantSource.Data.Interfaces
{
    public interface IDbContext
    {
        IDbSet<TEntity> Set<TEntity>() where TEntity : class;
        int SaveChanges();
        void Dispose();

    }
}
