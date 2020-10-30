using System;
using System.Collections.Generic;
using System.Text;

namespace FamilyTask.DataAccess.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Add(TEntity tEntity);
        void Update(TEntity tEntity);
        void AddRange(IEnumerable<TEntity> tEntity);
        void Remove(TEntity tEntity);
    }
}
