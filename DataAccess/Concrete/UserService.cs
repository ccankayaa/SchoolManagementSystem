using Microsoft.AspNetCore.Identity;
using SchoolManagementSystem.DataAccess.Abstract;
using SchoolManagementSystem.Models;
using System.Linq.Expressions;

namespace SchoolManagementSystem.DataAccess.Concrete
{
    public class UserService : Repository<User>, IUserRepository
    {
        private readonly SchoolDbContext _context;
        public UserService(SchoolDbContext context)
        {
            _context = context;
        }
        public User Create(User entity)
        {
            var result = _context.Set<User>().Add(entity);
            _context.SaveChanges();
            if (result != null)
            {
                switch (result.Entity.UserType)
                {
                    case UserType.Teacher:
                        _context.Set<Teacher>().Add(new Teacher
                        {
                            UserId = entity.Id
                        });
                        _context.SaveChanges();
                        break;
                    case UserType.Student:
                        _context.Set<Student>().Add(new Student
                        {
                            UserId = entity.Id
                        });
                        break;
                    default:
                        break;
                }
            }

            return result.Entity;
        }

        public User Create(User entity, int id)
        {
            throw new NotImplementedException();
        }

        public void Create(ICollection<User> entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(ICollection<User> entity)
        {
            throw new NotImplementedException();
        }

        public IList<User> FindByCondition(Expression<Func<User, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public IList<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public User GetById(long id)
        {
            throw new NotImplementedException();
        }

        public User GetById(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(User entity)
        {
            throw new NotImplementedException();
        }

        public void Update(User entity, int id)
        {
            throw new NotImplementedException();
        }

        public void Update(ICollection<User> entity)
        {
            throw new NotImplementedException();
        }
    }
}
