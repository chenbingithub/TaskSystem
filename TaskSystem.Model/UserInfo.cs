using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TaskSystem.Model
{
    [DataContract]
    [Table("UserInfos")]
    public class UserInfo: Entity<int>
    {
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public string Pwd { get; set; }
    }
}
