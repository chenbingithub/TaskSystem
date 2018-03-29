using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using TaskSystem.Model;

namespace TaskSystem.Model
{
    [DataContract]
    public abstract class Entity<TPrimaryKey> : IEntity<TPrimaryKey>
    {
        [DataMember]
        public virtual TPrimaryKey Id { get; set; }
        [DataMember]
        public virtual bool IsDelete { get; set; }

       
    }
}
