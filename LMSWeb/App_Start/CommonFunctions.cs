using LMSBL.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace LMSWeb.App_Start
{
    public class CommonFunctions
    {
        Exceptions newException = new Exceptions();
        public string GetEncodePassword(string password)
        {
            try
            {
                string encodePassword = string.Empty;
                MD5 md5 = new MD5CryptoServiceProvider();
                UTF8Encoding encoder = new UTF8Encoding();
                Byte[] originalBytes = encoder.GetBytes(password);
                Byte[] encodedBytes = md5.ComputeHash(originalBytes);
                password = BitConverter.ToString(encodedBytes).Replace("-", "");
                encodePassword = password.ToLower();
                return encodePassword;
            }
            catch (Exception ex)
            {
                newException.AddException(ex);
                return null;
            }
        }
    }
}