using System.Collections.Generic;

namespace SharedModel
{
    public interface IRepository<T>
        where T : IDomainObject, new()
    {
        IEnumerable<T> GetAll();
        void Delete(T obj);
        void Add(T obj);
    }
}