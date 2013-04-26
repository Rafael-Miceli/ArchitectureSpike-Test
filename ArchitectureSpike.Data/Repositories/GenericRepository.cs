using System;
using System.Collections.Generic;
using ArchitectureSpike.Data.Context;
using ArchitectureSpike.Domain.Interfaces;

namespace ArchitectureSpike.Data.Repositories
{
    public class GenericRepository<TUEntity>: IGenericRepository<TUEntity> where TUEntity : class
    {
        private readonly AssociateContext _context;
        protected AssociateContext Context { get { return _context; } }

        public GenericRepository(AssociateContext context)
        {
            _context = context;
        }

        public GenericRepository()
        {
            _context = new AssociateContext();
        }
        
        public IEnumerable<TUEntity> Query(Func<TUEntity, bool> filter)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Create(TUEntity entiteDto)
        {
            throw new NotImplementedException();
        }

        public virtual void Update(TUEntity entityToUpdate)
        {
            
        }

        public void Remove(TUEntity entitieDto)
        {
            
        }

        public IEnumerable<TUEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public TUEntity GetById(object identitieDto)
        {
            return _context.Set<TUEntity>().Find(identitieDto);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
