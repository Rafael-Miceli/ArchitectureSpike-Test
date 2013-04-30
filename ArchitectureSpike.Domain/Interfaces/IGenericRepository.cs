using System;
using System.Collections.Generic;

namespace ArchitectureSpike.Domain.Interfaces
{
    public interface IGenericRepository<TUEntity> : IRepository<TUEntity>
        where TUEntity : class
    {
        new IEnumerable<TUEntity> Query(Func<TUEntity, bool> filter);

        new void Save();

        new void Create(TUEntity entiteDto);
        
        new void Update(TUEntity entityToUpdate);
        
        new void Remove(TUEntity entitieDto);
        
        new IEnumerable<TUEntity> GetAll();

        new TUEntity GetById(object identitieDto);
    }
}
