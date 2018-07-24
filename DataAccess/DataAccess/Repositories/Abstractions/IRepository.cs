using System.Collections.Generic;

namespace DataAccess.Abstractions
{
    public interface IRepository<T>
    {
        List<T> Get { get; }

        void Insert(T entity);

        void Save();
    }
}
