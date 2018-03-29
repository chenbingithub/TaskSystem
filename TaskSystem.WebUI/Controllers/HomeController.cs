using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaskSystem.Model;
using TaskSystem.WebUI.UserInfoServiceReference;

namespace TaskSystem.WebUI.Controllers
{
    public class HomeController : Controller
    {
        UserInfoServiceReference.UserServiceClient client=new UserServiceClient();

       
        // GET: Home
        public ActionResult Index()
        {
            client.Insert(new UserInfo()
            {
                UserName = "admin",
                Pwd = "123456"
            });
            return View();
        }

        
    }
}
