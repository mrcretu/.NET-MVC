using DataAccess.Abstractions;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Implementations
{
    public class Repository<T> : IRepository<T> where T : BaseEntity 
    {
        protected readonly AppDbContext _context;

        public Repository(AppDbContext context)
        {
            _context = context;
        }

        public List<T> Get => _context.Set<T>().ToList();

        public void Insert(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
