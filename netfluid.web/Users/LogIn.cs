using System;
using System.Linq;

namespace Netfluid.Access
{
    public class LogIn
	{
        const string charset = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM123456789!£$%&/()=?^+;,:.-";

        public string UserName { get; set; }

        public string Domain { get; set; }

        public bool DomainAdmin { get; set; }

        public bool GlobalAdmin { get; set; }

        public string Password { get; set; }

        public DateTime LastLogin { get; set; }

        public DateTime LastModify { get; set; }

        public string Salt { get; set; }

        public int Round { get; set; }

        public string Method { get; set; }

        public LogIn()
        {
            UserName = "anon";
        }

        public LogIn(string fullname)
        {
            int index = fullname.IndexOf('@');
            UserName = (index > 0) ? fullname.Substring(0, index) : fullname;
            Domain = (index >= 0) ? fullname.Substring(index) : null;
        }

        public bool SignIn(string pass)
        { 
            Func<string, string> method;

            switch (Method)
            {
                case "SHA1": method = new Func<string, string>(Security.SHA1); break;
                case "SHA256": method = new Func<string, string>(Security.SHA256); break;
                case "SHA384": method = new Func<string, string>(Security.SHA384); break;
                case "SHA512": method = new Func<string, string>(Security.SHA512); break;
                default:
                    throw new Exception("Invalid cryptography method into user database");
            }

            string newPassword = "";
            for (int i = 0; i < Round; i++)
            {
                newPassword = method(pass + Salt);
            }
            if (Password == newPassword)
            {
                LastLogin = DateTime.Now;
                return true;
            }
            return false;
        }

        public void ChangePassword(string password)
        {
            string salt = new string(charset.Random(32).ToArray<char>());
            int rounds = Security.Random(4000);
            Func<string, string>[] methods = new Func<string, string>[]
            {
                new Func<string, string>(Security.SHA1),
                new Func<string, string>(Security.SHA256),
                new Func<string, string>(Security.SHA384),
                new Func<string, string>(Security.SHA512)
            };
            Func<string, string> method = methods.Random();
            string newPassword = "";
            for (int i = 0; i < rounds; i++)
            {
                newPassword = method(password + salt);
            }

            Salt = salt;
            Round = rounds;
            Method = method.Method.Name;
            Password = newPassword;
        }

        public override string ToString()
		{
            return UserName;
		}

        public static LogIn Parse(string name)
		{
            return new LogIn { UserName = name };
		}
    }
}
