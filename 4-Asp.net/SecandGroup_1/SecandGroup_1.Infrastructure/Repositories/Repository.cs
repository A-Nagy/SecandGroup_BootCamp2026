

using Microsoft.EntityFrameworkCore;
using SecandGroup_1.Application.Abstractions.Repositories;
using SecandGroup_1.Infrastructure.Data;

namespace SecandGroup_1.Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public readonly ApplicationDbContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
            //_context.SaveChanges();
        }
        public void Update(T entity)
        {
            _dbSet.Update(entity);
            //_context.SaveChanges();
        }
        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
            //_context.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

       
    }
}
