using System;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace _02_Authorization
{
    public class SecurityAuthorization
    {
        private const string nameCookie = "name";
        private const string signCookie = "sign";

        public delegate bool LogPassChecker(string login, string password);

        public LogPassChecker Checker;
        public string CurrentUser
        {
            get
            {
                var name = HttpContext.Current.Request.Cookies[nameCookie];
                var sign = HttpContext.Current.Request.Cookies[signCookie];

                if (name != null && sign?.Value == GenerateMD5Hash(name.Value + key))
                    return name.Value;

                return null;
            }
        }

        public string key { get; private set; } = "asyguixumqwydcbnew7823142yroshf moadsbhfk caxmsi,z";

        public bool Authorize(string login, string password, string redirectUrl = "Default.aspx", LogPassChecker checker = null)
        {
            if (Checker == null && checker == null)
                throw new Exception("LogPassChecker undefined");

            if (checker == null)
                checker = Checker;

            if (!checker(login, password))
                return false;

            var hash = GenerateMD5Hash(login + key);

            var name = HttpContext.Current.Request.Cookies[nameCookie];
            var sign = HttpContext.Current.Request.Cookies[signCookie];

            if (name == null)
            {
                HttpContext.Current.Response.Cookies.Add(new HttpCookie(nameCookie, login));
                HttpContext.Current.Response.Cookies.Add(new HttpCookie(signCookie, hash));
                HttpContext.Current.Response.Redirect(redirectUrl);
                return true;
            }

            if(sign == null)
            {
                HttpContext.Current.Request.Cookies.Add(new HttpCookie(signCookie, hash));
                SignOut();
            }

            return hash == sign?.Value;
        }

        public bool SignOut(string redirectUrl = "Default.aspx")
        {
            var name = HttpContext.Current.Request.Cookies[nameCookie];
            var sign = HttpContext.Current.Request.Cookies[signCookie];
            var hash = GenerateMD5Hash(name?.Value + key);

            if (hash == sign?.Value)
            {
                name.Expires = DateTime.Now.AddDays(-1);
                sign.Expires = name.Expires;
                name.Value = string.Empty;
                sign.Value = string.Empty;
                HttpContext.Current.Response.Cookies.Add(name);
                HttpContext.Current.Response.Cookies.Add(sign);
                HttpContext.Current.Response.Redirect(redirectUrl);
                return true;
            }

            return false;
        }

        private string GenerateMD5Hash(string source)
        {
            var provider = new MD5CryptoServiceProvider();
            var hash = provider.ComputeHash(Encoding.Default.GetBytes(source));
            return BitConverter.ToString(hash).ToLower().Replace("-", string.Empty);
        }
    }
}