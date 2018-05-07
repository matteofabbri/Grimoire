using Netfluid;

namespace Elettra.AccessControl
{
    class Locker
    {
        [Filter]
        public dynamic Filter(Context cnt)
        {
            if (cnt.Request.Url.LocalPath.StartsWith("/users/signin")) return false;

            if (cnt.Request.Url.LocalPath.StartsWith("/public/")) return false;

            var user = cnt.Session<StaffAccess>("user");

            if (user == null)
                return new MustacheTemplate("./views/access/login.html");

            return false;
        }

        public IResponse SignIn(string username, string password, Context cnt)
        {
            var user = AccessManager.Get(username);

            if(user==null)
                return new MustacheTemplate("./views/access/login.html");

            if (user.SignIn(password))
                return new MustacheTemplate("./views/access/login.html");

            cnt.Session("user", user);
            return new RedirectResponse("/");
        }
    }
}
