using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSystem.Model
{
    public class UserInfo: Entity<int>
    {
        public string UserName { get; set; }
        public string Pwd { get; set; }
    }
}
