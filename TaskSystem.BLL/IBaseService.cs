
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using TaskSystem.DAL.Session;
using TaskSystem.Model;
using TaskSystem.Model.IRepository;

namespace TaskSystem.BLL
{
   public interface IBaseService<TEntity, TPrimaryKey> where TEntity : class, IEntity<TPrimaryKey>
    {
        IQueryable<TEntity> GetAll();

        TEntity GetModel(Expression<Func<TEntity, bool>> where);

        IQueryable<TEntity> GetList(Expression<Func<TEntity, bool>> whereLambda);


        bool Insert(TEntity entity);


        bool Update(TEntity entity);


        bool Delete(TEntity entity);
       
        bool Delete(TPrimaryKey id);

        bool DeleteList(List<TPrimaryKey> ids);


        /// <summary>
        /// 软删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool DeleteByLogical(TEntity entity);
        
    }
}
