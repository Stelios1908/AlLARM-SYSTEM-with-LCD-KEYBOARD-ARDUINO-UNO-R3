using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AlarmSystem
{
    public class Hashing
    {
        public static string HashUsernameOrPassword(string usenameOrPwd)
        {
            using (SHA256 sha256 = new SHA256Managed())
            {
                byte[] usernameOrpasswordBytes = Encoding.UTF8.GetBytes(usenameOrPwd);
                byte[] hashedBytes = sha256.ComputeHash(usernameOrpasswordBytes);
                string hashedusernameOrPassword = Convert.ToBase64String(hashedBytes);
                return hashedusernameOrPassword;
            }
        }

        public static bool VerifyUsernameOrPassword(string input1UsernameOrPwd, string input2UsernameOrPwd)
        {
            string input1Hashed = HashUsernameOrPassword(input1UsernameOrPwd);
            return input1Hashed == input2UsernameOrPwd;
        }
    }
}
