using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq.Expressions;
using ArchitectureSpike.Data.Context;
using ArchitectureSpike.Domain.Interfaces;

namespace ArchitectureSpike.Data.Repositories
{
    public class GenericRepository<TEntity, TUEntity> : IRepository<TUEntity>, IDisposable
        where TUEntity : class
        where TEntity : class
    {

        private readonly AssociateContext _context;
        protected AssociateContext Context { get { return _context; } }
        private readonly DbSet<TEntity> _dbSet;
        private TEntity _entity;

        public GenericRepository(AssociateContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
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
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            Dispose();
        }
    }
}
