using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;

namespace TaskSystem.DAL.Session
{
    public class DbSessionFactory
    {
        //public static IDbSession db = null;

        //static DbSessionFactory()
        //{
        //    db = new DbSession();
        //}

        public static IDbSession GetCurrentDbSession()
        {
            IDbSession db = CallContext.GetData("DbSession") as IDbSession;
            if (db == null)
            {
                db = new DbSession();
                CallContext.SetData("DbSession", db);
            }
            return db;
        }
    }
}
