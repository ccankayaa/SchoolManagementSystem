using System.Linq.Expressions;

namespace SchoolManagementSystem.DataAccess.Abstract
{
    public interface IRepository<T> where T : class
    {
        T GetById(int id);
        T GetById(long id);
        IList<T> GetAll();
        IList<T> FindByCondition(Expression<Func<T, bool>> expression);
        T Create(T entity);
        T Create(T entity, int id);
        void Create(ICollection<T> entity);
        void Update(T entity);
        void Update(T entity, int id);
        void Update(ICollection<T> entity);
        void Delete(T entity);
        void Delete(ICollection<T> entity);
    }
}
