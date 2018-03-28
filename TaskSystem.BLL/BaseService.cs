
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using TaskSystem.DAL.Session;
using TaskSystem.Model;
using TaskSystem.Model.IRepository;

namespace TaskSystem.BLL.IBusiness
{
   public abstract class BaseService<TEntity, TPrimaryKey> where TEntity : class, IEntity<TPrimaryKey>
    {
       public IBaseDAL<TEntity,TPrimaryKey> CurretDAL { get; set; }
       public IDbSession DbSession { get { return DbSessionFactory.GetCurrentDbSession(); } }
       public abstract void SetCurrentDal();//抽象方法，让子类来实现

        #region 构造方法
       public BaseService()
       {
           SetCurrentDal();
       } 
       #endregion

        #region 查询操作
       public IQueryable<TEntity> GetAll()
       {
           return CurretDAL.GetAll();
       }
       public TEntity GetModel(Expression<Func<TEntity, bool>> where)
       {
           return CurretDAL.GetAll().FirstOrDefault(where);
       }
       public IQueryable<TEntity> GetList(Expression<Func<TEntity, bool>> whereLambda)//条件查询方法
       {
           return CurretDAL.GetAll().Where(whereLambda);
       } 
       #endregion

       

        #region 添加操作
           public bool Insert(TEntity entity)
           {
               CurretDAL.Insert(entity);
            return DbSession.SaveChanges() > 0;
        }
          
        #endregion

        #region 修改操作

         public  bool Update(TEntity entity)
        {
            CurretDAL.Update(entity);
            return DbSession.SaveChanges() > 0;
        }
        
        #endregion

        #region 删除操作
        public bool Delete(TEntity entity)
        {
            CurretDAL.Delete(entity);
            return DbSession.SaveChanges() > 0;
        }
        public bool Delete(TPrimaryKey id)
        {
            CurretDAL.Delete(id);
            return DbSession.SaveChanges() > 0;
        }
        public bool DeleteList(List<TPrimaryKey> ids)
        {
            ids.ForEach(x => { CurretDAL.Delete(x); });
            return DbSession.SaveChanges()>0;
        }
        #endregion
        #region 删除之软删除
        /// <summary>
        /// 软删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool DeleteByLogical(TEntity entity)
        {
            entity.IsDelete = true;
            CurretDAL.Update(entity);
            return DbSession.SaveChanges()>0;
        } 
        #endregion
    }
}
