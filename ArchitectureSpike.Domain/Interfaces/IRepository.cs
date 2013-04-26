using System;
using System.Collections.Generic;

namespace ArchitectureSpike.Domain.Interfaces
{
    public interface IRepository<T>
    {
        void Create(T entiteDto);
        void Update(T entiteDto);
        void Remove(T entiteDto);
        IEnumerable<T> GetAll();
        IEnumerable<T> Query(Func<T, bool> filter);
        T GetById(object entiteDto);
        void Save();
    }
}
