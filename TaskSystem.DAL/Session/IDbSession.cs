using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskSystem.Model.IRepository;

namespace TaskSystem.DAL.Session
{
    
    public interface IDbSession
    {
        IUserInfoDAL UserInfoDAL { get; }
        int SaveChanges();
    }
}
