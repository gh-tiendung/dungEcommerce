using System.Linq.Expressions;

namespace dungEcommerce.Service.IServices
{
    public interface IGenericRepository<TEntity, TModel> where TEntity : class where TModel : class
    {
        TModel GetById(Guid id);
        IEnumerable<TModel> GetAll();
        IEnumerable<TModel> Find(Expression<Func<TModel, bool>> expression);
        void Add(TModel model);
        void AddRange(IEnumerable<TModel> models);
        void Update(TModel model);
        void UpdateRange(IEnumerable<TModel> models);
        void Remove(TModel model);
        void RemoveRange(IEnumerable<TModel> models);
    }
}