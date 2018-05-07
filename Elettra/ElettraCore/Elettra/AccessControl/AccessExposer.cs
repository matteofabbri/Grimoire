using Netfluid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elettra.AccessControl
{
    [Route("/users")]
    static class AccessExposer
    {
        [Route("/signin")]
        public static IResponse SignIn(string username,string password,bool remember, Context cnt)
        {
            var user = AccessManager.SignIn(username, password);

            if (user == null)
                return new MustacheTemplate("./views/access/login.html");

            cnt.Session("user", user);


            return new RedirectResponse("/");
        }
    }
}
