using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TaskSystem.Model.IRepository;

namespace TaskSystem.DAL.Session
{
    
    public class StaticDALFactory
    {
        public static string assemblyName = System.Configuration.ConfigurationManager.AppSettings["DALAssemblyName"];

        public static IUserInfoDAL GetUserInfoDAL()
        {
            return Assembly.Load(assemblyName).CreateInstance(assemblyName + ".UserInfoDAL") as IUserInfoDAL;
        }

    }
}
