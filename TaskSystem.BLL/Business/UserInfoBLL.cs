using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskSystem.BLL.IBusiness;
using TaskSystem.Model;

namespace TaskSystem.BLL.Business
{

    public class UserInfoBLL : BaseService<UserInfo, int>, IUserInfoBLL
    {
        public override void SetCurrentDal()
        {
            CurretDAL = DbSession.UserInfoDal;
        }
    }
}
