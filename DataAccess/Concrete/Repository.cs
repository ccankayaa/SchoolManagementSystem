using SchoolManagementSystem.DataAccess.Abstract;
using System.Linq.Expressions;

namespace SchoolManagementSystem.DataAccess.Concrete
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public T Create(T entity)
        {
            throw new NotImplementedException();
        }

        public T Create(T entity, int id)
        {
            throw new NotImplementedException();
        }

        public void Create(ICollection<T> entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(ICollection<T> entity)
        {
            throw new NotImplementedException();
        }

        public IList<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public IList<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public T GetById(long id)
        {
            throw new NotImplementedException();
        }

        public T GetById(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity, int id)
        {
            throw new NotImplementedException();
        }

        public void Update(ICollection<T> entity)
        {
            throw new NotImplementedException();
        }
    }
}
