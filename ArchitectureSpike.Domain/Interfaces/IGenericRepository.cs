using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ArchitectureSpike.Domain.Interfaces
{
    public interface IGenericRepository<TUEntity> where TUEntity : class
    {
        new IEnumerable<TUEntity> Query(params Expression<Func<TUEntity, object>>[] filter);

        new void Save();

        new void Create(TUEntity entite);
        
        new void Update(TUEntity entityToUpdate);
        
        new void Remove(TUEntity entitie);
        
        new IEnumerable<TUEntity> GetAll();

        new TUEntity GetById(object identitie);
    }
}
