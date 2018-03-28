using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskSystem.Model;

namespace TaskSystem.Model
{

    public abstract class Entity<TPrimaryKey> : IEntity<TPrimaryKey>
    {
       public virtual TPrimaryKey Id { get; set; }
       public virtual bool IsDelete { get; set; }

       
    }
}
