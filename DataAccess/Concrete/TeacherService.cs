using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.DataAccess.Abstract;
using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.DataAccess.Concrete
{
    public class TeacherService :Repository<Teacher>, ITeacherRepository
    {
        private readonly SchoolDbContext _context;
        public TeacherService(SchoolDbContext context)
        {

            _context = context;

        }
        public Teacher Create(Teacher entity)
        {
            throw new NotImplementedException();
        }

        public Teacher Create(Teacher entity, int id)
        {
            throw new NotImplementedException();
        }

        public void Create(ICollection<Teacher> entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Teacher entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(ICollection<Teacher> entity)
        {
            throw new NotImplementedException();
        }

        public IList<Teacher> FindByCondition(System.Linq.Expressions.Expression<Func<Teacher, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public IList<Teacher> GetAll()
        {
            throw new NotImplementedException();
        }

        public Teacher GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Teacher GetById(long id)
        {
            throw new NotImplementedException();
        }

        public Teacher GetById(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(Teacher entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Update(Teacher entity, int id)
        {
            throw new NotImplementedException();
        }

        public void Update(ICollection<Teacher> entity)
        {
            throw new NotImplementedException();
        }
    }
}
