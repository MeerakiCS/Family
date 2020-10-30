using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FamilyTask.DataAccess.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly ApplicationDbContext _dbContext;
        public Repository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add(TEntity tEntity)
        {
            _dbContext.Set<TEntity>().Add(tEntity);
            _dbContext.SaveChanges();
        }
        public void AddRange(IEnumerable<TEntity> tEntity)
        {
            _dbContext.Set<TEntity>().AddRange(tEntity);
            _dbContext.SaveChanges();
        }
        public IEnumerable<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>().ToList();
        }
        public TEntity GetById(int id)
        {
            return _dbContext.Set<TEntity>().Find(id);
        }
        public void Remove(TEntity tEntity)
        {
            _dbContext.Set<TEntity>().Remove(tEntity);
            _dbContext.SaveChanges();
        }
        public void Update(TEntity tEntity)
        {
            _dbContext.Set<TEntity>().Update(tEntity);
            _dbContext.SaveChanges();
        }
        public void RemoveRange(IEnumerable<TEntity> tEntity)
        {
            _dbContext.Set<TEntity>().RemoveRange(tEntity);
            _dbContext.SaveChanges();
        }
    }
}
