using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TaskSystem.Model.IRepository
{
    
    public interface IBaseDAL<TEntity, TPrimaryKey> where TEntity : class, IEntity<TPrimaryKey>
    {
         IQueryable<TEntity> GetAll();




         TEntity Insert(TEntity entity);




        TEntity Update(TEntity entity);




        void Delete(TEntity entity);

        void Delete(TPrimaryKey id);

        TEntity FirstOrDefault(TPrimaryKey id);


         int Count();


        int Count(Expression<Func<TEntity, bool>> predicate);


        long LongCount();


        long LongCount(Expression<Func<TEntity, bool>> predicate);
        
    }
}
