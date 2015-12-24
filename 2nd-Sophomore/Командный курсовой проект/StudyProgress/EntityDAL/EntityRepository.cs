using System.Collections.Generic;
using SharedModel;

namespace EntityDAL
{
    internal class EntityRepository<T> : IRepository<T> where T : class, IDomainObject, new()
    {
        private readonly DataContext _context;

        public EntityRepository(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public void Delete(T obj)
        {
            _context.Set<T>().Remove(obj);
        }

        public void Add(T obj)
        {
            _context.Set<T>().Add(obj);
        }
    }
}