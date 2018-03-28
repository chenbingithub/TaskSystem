using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskSystem.Model.IRepository;

namespace TaskSystem.DAL.Session
{

    public class DbSession : IDbSession
    {
        public IUserInfoDAL UserInfoDAL
        {
            get
            {
                return StaticDALFactory.GetUserInfoDAL();
            }
        }

        /// <summary>
        /// 向数据库提交的方法
        /// </summary>
        /// <returns></returns>
        public int SaveChanges()
        {
            return DbContextFactory.GetCurrentDbContext().SaveChanges();
        }
    }
}
