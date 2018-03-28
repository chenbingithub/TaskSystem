﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;

namespace TaskSystem.DAL
{
   public class DbContextFactory
    {
       public static DbContext GetCurrentDbContext()
       {
           //return new DataModelContainer();
           DbContext db = CallContext.GetData("DbContext") as DbContext;
           if (db == null) {
               db = new TaskSystemDbContext();
               CallContext.SetData("DbContext", db);
           }
           return db;
       }
    }
    public partial class TaskSystemDbContext: DbContext
    {
        public TaskSystemDbContext()
            : base("name=DataModelContainer")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new System.Data.Entity.Infrastructure.UnintentionalCodeFirstException();
        }

        public DbSet<TaskSystem.Model.UserInfo> UserInfos { get; set; }
       
    }
}
