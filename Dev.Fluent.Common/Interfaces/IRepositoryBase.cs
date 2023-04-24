using Dev.Fluent.Common.Models;

namespace Dev.Fluent.Common.Interfaces
{
    public interface IRepositoryBase<TEntity>
        where TEntity : EntityBase
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(Guid id);
        void DeleteById(Guid id);
        void CreateOrUpdate(TEntity entity);
    }
}
