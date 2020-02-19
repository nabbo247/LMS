
using System;
using System.Text;
using System.Security.Cryptography;

namespace HRS.CoursePlayer
{
    public class IDGenerator
    {
        /// <summary>
        /// Function to get 15 to 16 digit unique number.
        /// </summary>
        /// <returns>15 or 16 digit alphanumeric GUID </returns>
        public static string GetStringGUID()
        {
            long i = 1;
            foreach (byte b in Guid.NewGuid().ToByteArray())
            {
                i *= ((int)b + 1);
            }
            return string.Format("{0:x}", i - DateTime.Now.Ticks);
        }

        /// <summary>
        /// Function to get 15 to 16 digit unique number.
        /// </summary>
        /// <returns>returns 15 to 16 digit unique number with provided prefix characters</returns>
        public static string GetStringGUIDWithPrefix(string pPrefix)
        {
            string strResult = string.Empty;
            long i = 1;
            foreach (byte b in Guid.NewGuid().ToByteArray())
            {
                i *= ((int)b + 1);
            }
            strResult = string.Format("{0:x}", i - DateTime.Now.Ticks);
            return pPrefix + strResult;
        }

        /// <summary>
        /// Function to get unique number of provided length.
        /// </summary>
        /// <returns>returns unique number of requested size</returns>
        public static string GetUniqueKey(int pMaxSize)
        {
            char[] arrChars = new char[62];
            string a;
            a = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            arrChars = a.ToCharArray();
            int size = pMaxSize;
            byte[] arrByteData = new byte[1];
            RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
            crypto.GetNonZeroBytes(arrByteData);
            size = pMaxSize;
            arrByteData = new byte[size];
            crypto.GetNonZeroBytes(arrByteData);
            StringBuilder sbResult = new StringBuilder(size);
            foreach (byte b in arrByteData)
            {
                sbResult.Append(arrChars[b % (arrChars.Length - 1)]);
            }
            return sbResult.ToString();
        }

        /// <summary>
        /// Function to get unique number of provided length.
        /// </summary>
        /// <returns>returns unique number with provided prefix attached and requested size </returns>
        public static string GetUniqueKeyWithPrefix(string pPrefix, int pMaxSize)
        {
            char[] arrChars = new char[62];
            string str;
            str = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            arrChars = str.ToCharArray();
            int size = pMaxSize;
            byte[] arrByteData = new byte[1];
            RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
            crypto.GetNonZeroBytes(arrByteData);
            size = pMaxSize;
            arrByteData = new byte[size];
            crypto.GetNonZeroBytes(arrByteData);
            StringBuilder sbResult = new StringBuilder(size);
            foreach (byte b in arrByteData)
            {
                sbResult.Append(arrChars[b % (arrChars.Length - 1)]);
            }
            return pPrefix + sbResult.ToString();
        }
    }
}