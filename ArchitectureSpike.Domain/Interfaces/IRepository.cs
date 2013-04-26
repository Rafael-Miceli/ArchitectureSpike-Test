using System.Collections.Generic;

namespace ArchitectureSpike.Domain.Interfaces
{
    public interface IRepository<T>
    {
        void Create(T entiteDto);
        void Update(T entiteDto);
        void Remove(T entiteDto);
        IEnumerable<T> GetAll(T entiteDto);
        T GetById(T entiteDto);
        void Save();
    }
}
