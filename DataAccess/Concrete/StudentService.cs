using SchoolManagementSystem.DataAccess.Abstract;
using SchoolManagementSystem.Models;
using System.Linq.Expressions;

namespace SchoolManagementSystem.DataAccess.Concrete
{
    public class StudentService : Repository<Student>, IStudentRepository
    {
        protected readonly SchoolDbContext _context;
        public StudentService(SchoolDbContext context)
        {

            _context = context;

        }
        public Student Create(Student entity)
        {
            var result = _context.Set<Student>().Add(entity);
            _context.SaveChanges();

            return result.Entity;
        }

        public Student Create(Student entity, int id)
        {
            throw new NotImplementedException();
        }

        public void Create(ICollection<Student> entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Student entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(ICollection<Student> entity)
        {
            throw new NotImplementedException();
        }

        public IList<Student> FindByCondition(Expression<Func<Student, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public IList<Student> GetAll()
        {
            var result = _context.Set<Student>().ToList();
            return result;
        }

        public Student GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Student GetById(long id)
        {
            throw new NotImplementedException();
        }

        public Student GetById(string id)
        {
            var result = _context.Set<Student>().FirstOrDefault(s => s.UserId == id);

            return result;
        }

        public void Update(Student entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Student entity, int id)
        {
            throw new NotImplementedException();
        }

        public void Update(ICollection<Student> entity)
        {
            throw new NotImplementedException();
        }
    }
}
