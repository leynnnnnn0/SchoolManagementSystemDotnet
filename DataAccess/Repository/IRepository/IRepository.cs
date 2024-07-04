using System.Linq.Expressions;

namespace DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Remove(T entity);
        IEnumerable<T> GetAll();
        T Get(Expression<Func<T, bool>> filter);
        T FindById(int? id);
    }
}
